using RegulusLibrary.Services.Sources.DataStructures;

namespace RegulusLibrary.Services.Sources;

public interface IBirdRecordsOldDbSource
{
    public IEnumerable<OldDbBirdRecord> Read();
}