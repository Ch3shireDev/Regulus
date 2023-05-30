using RegulusLibrary.DataStructures;

namespace RegulusLibrary.Services.Sources;

public interface IBirdRecordsDbSource
{
    IEnumerable<BirdRecord> Read();
}