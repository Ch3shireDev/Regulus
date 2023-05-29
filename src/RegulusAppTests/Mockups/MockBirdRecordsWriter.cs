using RegulusLibrary.Services.Loaders;
using RegulusLibrary.Services.Writers;

namespace RegulusAppTests.Mockups;

public class MockBirdRecordsWriter : IBirdRecordsWriter
{
    public bool IsWriteRecordsCalled = true;
    public BirdRecordsSaverParameters Parameters;

    public void WriteRecords(BirdRecordsSaverParameters parameters)
    {
        IsWriteRecordsCalled = true;
        Parameters = parameters;
    }
}