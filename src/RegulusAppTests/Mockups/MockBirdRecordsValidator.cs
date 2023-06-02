using RegulusLibrary.DataStructures;
using RegulusLibrary.Services.Validators;

namespace RegulusAppTests.Mockups;

public class MockBirdRecordsValidator : IBirdRecordsValidator
{
    public BirdRecordWrapper? InputData { get; set; }
    public bool Output { get; set; }
    public bool IsValidCalled { get; set; }

    public bool IsValid(BirdRecordWrapper birdRecord)
    {
        InputData = birdRecord;
        IsValidCalled = true;
        return Output;
    }
}