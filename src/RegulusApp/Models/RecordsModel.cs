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

    public IEnumerable<BirdRecord> GetRecords(BirdRecordsLoaderParameters parameters)
    {
        return _birdRecordsLoader.GetRecords(parameters);
    }

    public void WriteRecordsToCsv(BirdRecordsSaverParameters parameters)
    {
        _birdRecordsWriter.WriteRecords(parameters);
    }
}