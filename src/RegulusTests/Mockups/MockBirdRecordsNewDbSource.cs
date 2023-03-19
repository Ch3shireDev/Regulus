using RegulusLibrary.Services.Sources;
using RegulusLibrary.Services.Sources.DataStructures;

namespace RegulusTests.Mockups;

public class MockBirdRecordsNewDbSource : IBirdRecordsNewDbSource
{
    public List<NewDbBirdRecord> BirdRecords { get; set; } = new List<NewDbBirdRecord>();

    public IEnumerable<NewDbBirdRecord> Read()
    {
        return BirdRecords;
    }
}