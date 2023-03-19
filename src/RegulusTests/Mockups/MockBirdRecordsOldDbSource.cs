using RegulusLibrary.Services.Sources;
using RegulusLibrary.Services.Sources.DataStructures;

namespace RegulusTests.Mockups;

public class MockBirdRecordsOldDbSource : IBirdRecordsOldDbSource
{
    public List<OldDbBirdRecord> BirdRecords { get; set; } = new List<OldDbBirdRecord>();

    public IEnumerable<OldDbBirdRecord> Read()
    {
        return BirdRecords;
    }
}