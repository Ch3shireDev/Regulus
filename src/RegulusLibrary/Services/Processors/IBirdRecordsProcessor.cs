using RegulusLibrary.DataStructures;

namespace RegulusLibrary.Services.Processors;

public interface IBirdRecordsProcessor
{
    IEnumerable<BirdRecordWrapper> Process(IEnumerable<BirdRecord> records);
}