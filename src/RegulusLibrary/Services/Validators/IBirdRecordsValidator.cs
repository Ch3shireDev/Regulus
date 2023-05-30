using RegulusLibrary.DataStructures;

namespace RegulusLibrary.Services.Validators;

public interface IBirdRecordsValidator
{
    public bool IsValid(BirdRecordWrapper birdRecord);
}