using RegulusLibrary.DataStructures;
using RegulusLibrary.Services.Sources;

namespace RegulusLibrary.Services.Loaders;

public class BirdRecordsLoader : IBirdRecordsLoader
{
    public IEnumerable<BirdRecord> GetRecords(BirdRecordsLoaderParameters parameters)
    {
        var filename = parameters.Filename;

        var oldDbSource = new AccessBirdRecordsOldDbSource(filename, "Tab_Ring_Podab");
        var newDbSource = new AccessBirdRecordsNewDbSource(filename, "AB 2017_18_19_20_21S");

        var source = new AccessBirdRecordsDbSource(oldDbSource, newDbSource);

        return source.Read();
    }
}

public class BirdRecordsLoaderParameters
{
    public string Filename{ get; set; }
}