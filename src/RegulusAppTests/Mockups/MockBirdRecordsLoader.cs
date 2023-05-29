using RegulusLibrary.DataStructures;
using RegulusLibrary.Services.Loaders;

namespace RegulusAppTests.Mockups;

public class MockBirdRecordsLoader : IBirdRecordsLoader
{
    public List<BirdRecord> BirdRecords { get; set; } = new List<BirdRecord>();
    public BirdRecordsLoaderParameters Parameters { get; set; } = new BirdRecordsLoaderParameters();

    public IEnumerable<BirdRecord> GetRecords(BirdRecordsLoaderParameters parameters)
    {
        Parameters = parameters;
        return BirdRecords;
    }
}