using System.Collections.Generic;
using RegulusLibrary.DataStructures;
using RegulusLibrary.Services.Loaders;

namespace RegulusApp.Models;

public class RecordsModel
{
    private readonly IBirdRecordsLoader _birdRecordsLoader;

    public RecordsModel(IBirdRecordsLoader birdRecordsLoader)
    {
        _birdRecordsLoader = birdRecordsLoader;
    }

    public IEnumerable<BirdRecord> GetRecords(BirdRecordsLoaderParameters parameters)
    {
        return _birdRecordsLoader.GetRecords(parameters);
    }
}