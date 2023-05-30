using RegulusLibrary.DataStructures;
using RegulusLibrary.Services.Processors;

namespace RegulusAppTests.Mockups;

public class MockBirdRecordProcessor:IBirdRecordsProcessor
{
    public IEnumerable<BirdRecord> InputData;
    public IEnumerable<BirdRecordWrapper> OutputData;
    public bool IsProcessCalled;

    public IEnumerable<BirdRecordWrapper> Process(IEnumerable<BirdRecord> records)
    {
        IsProcessCalled = true;
        InputData = records;
        return OutputData;
    }
}