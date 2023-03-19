using RegulusLibrary.Services.Sources.DataStructures;

namespace RegulusLibrary.Services.Sources;

public interface IBirdRecordsNewDbSource
{
    public IEnumerable<NewDbBirdRecord> Read();
}