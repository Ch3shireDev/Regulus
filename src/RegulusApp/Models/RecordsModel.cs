using System.Collections.Generic;
using RegulusLibrary.DataStructures;
using RegulusLibrary.Services.Loaders;
using RegulusLibrary.Services.Processors;
using RegulusLibrary.Services.Validators;
using RegulusLibrary.Services.Writers;

namespace RegulusApp.Models;

public class RecordsModel
{
    private readonly IBirdRecordsLoader _loader;
    private readonly IBirdRecordsProcessor _processor;
    private readonly IBirdRecordsValidator _validator;
    private readonly IBirdRecordsWriter _writer;


    public RecordsModel(IBirdRecordsLoader loader, IBirdRecordsWriter writer, IBirdRecordsProcessor processor, IBirdRecordsValidator validator)
    {
        _loader = loader;
        _writer = writer;
        _processor = processor;
        _validator = validator;
    }

    public IEnumerable<BirdRecordWrapper> GetRecordWrappers(BirdRecordsLoaderParameters parameters)
    {
        var records = _loader.GetRecords(parameters);
        return _processor.Process(records);
    }


    public void WriteRecordsToCsv(BirdRecordsSaverParameters parameters)
    {
        _writer.WriteRecords(parameters);
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

    public bool CheckIsValid(BirdRecordWrapper record)
    {
        return _validator.IsValid(record);
    }
}