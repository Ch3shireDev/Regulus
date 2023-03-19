using RegulusLibrary.Services.Sources.DataStructures;

namespace RegulusLibrary.Services.Sources;

public interface INewDbBirdRecordsSource
{
    public IEnumerable<NewDbBirdRecord> Read();
}