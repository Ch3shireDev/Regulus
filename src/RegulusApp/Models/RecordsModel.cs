using System.Collections.Generic;
using RegulusLibrary.DataStructures;
using RegulusLibrary.Services.Loaders;
using RegulusLibrary.Services.Processors;
using RegulusLibrary.Services.Writers;

namespace RegulusApp.Models;

public class RecordsModel
{
    private readonly IBirdRecordsLoader _birdRecordsLoader;
    private readonly IBirdRecordsWriter _birdRecordsWriter;
    private readonly IBirdRecordsProcessor _birdRecordsProcessor;


    public RecordsModel(IBirdRecordsLoader birdRecordsLoader, IBirdRecordsWriter birdRecordsWriter, IBirdRecordsProcessor birdRecordsProcessor)
    {
        _birdRecordsLoader = birdRecordsLoader;
        _birdRecordsWriter = birdRecordsWriter;
        _birdRecordsProcessor = birdRecordsProcessor;
    }

    public IEnumerable<BirdRecordWrapper> GetRecordWrappers(BirdRecordsLoaderParameters parameters)
    {
        var records = _birdRecordsLoader.GetRecords(parameters);
        return _birdRecordsProcessor.Process(records);
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