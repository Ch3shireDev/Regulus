using System.Collections.Generic;
using RegulusLibrary.DataStructures;
using RegulusLibrary.Services.Loaders;
using RegulusLibrary.Services.Writers;

namespace RegulusApp.Models;

public class RecordsModel
{
    private readonly IBirdRecordsLoader _birdRecordsLoader;
    private readonly IBirdRecordsWriter _birdRecordsWriter;

    public RecordsModel(IBirdRecordsLoader birdRecordsLoader, IBirdRecordsWriter birdRecordsWriter)
    {
        _birdRecordsLoader = birdRecordsLoader;
        _birdRecordsWriter = birdRecordsWriter;
    }

    public IEnumerable<BirdRecordWrapper> GetRecordWrappers(BirdRecordsLoaderParameters parameters)
    {
        var records = _birdRecordsLoader.GetRecords(parameters);
        var result = new List<BirdRecordWrapper>();

        foreach (var recordWrapper in records)
        {
            var record = new BirdRecordWrapper
            {
                Id = recordWrapper.Id,
                SpeciesCode = recordWrapper.SpeciesCode,
                Sex = recordWrapper.Sex,
                Wing = recordWrapper.Wing,
                Tail = recordWrapper.Tail,
                Weight = recordWrapper.Weight,
                DateTime = recordWrapper.DateTime
            };

            result.Add(record);
        }

        return result;
    }

    public void WriteRecordsToCsv(BirdRecordsSaverParameters parameters)
    {
        _birdRecordsWriter.WriteRecords(parameters);
    }

    public List<BirdRecord> AsSimpleRecords(List<BirdRecordWrapper> records)
    {
        var results = new List<BirdRecord>();

        foreach (var recordWrapper in records)
        {
            var record = new BirdRecord
            {
                Id = recordWrapper.Id,
                SpeciesCode = recordWrapper.SpeciesCode,
                Sex = recordWrapper.Sex,
                Wing = recordWrapper.Wing,
                Tail = recordWrapper.Tail,
                Weight = recordWrapper.Weight,
                DateTime = recordWrapper.DateTime
            };

            results.Add(record);
        }

        return results;
    }
}