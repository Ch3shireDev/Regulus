using RegulusLibrary.DataStructures;

namespace RegulusLibrary.Services;

public interface IBirdRecordsDbSource
{
    IEnumerable<BirdRecord> Read();
}