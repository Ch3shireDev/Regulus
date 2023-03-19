using RegulusLibrary.DataStructures;

namespace RegulusLibrary.Services.Loaders;

public interface IBirdRecordsLoader
{
    IEnumerable<BirdRecord> GetRecords(BirdRecordsLoaderParameters parameters);
}