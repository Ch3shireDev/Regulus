using System.Text;
using RegulusLibrary.DataStructures;
using RegulusLibrary.Services.Sources;

namespace RegulusLibrary.Services.Loaders;

public class BirdRecordsLoader : IBirdRecordsLoader
{
    public IEnumerable<BirdRecord> GetRecords(BirdRecordsLoaderParameters parameters)
    {
        var filename = parameters.Filename;
        var extension = Path.GetExtension(filename);

        if (extension == ".mdb")
        {
            return GetRecordsFromAccessDatabase(filename);
        }

        if (extension == ".csv")
        {
            return GetRecordsFromCsvFile(filename);
        }

        throw new ArgumentException("Invalid file extension.");
    }

    private IEnumerable<BirdRecord> GetRecordsFromCsvFile(string filename)
    {
        var stringReader = new StreamReader(filename, Encoding.UTF8);
        var streader = new StringReader(stringReader.ReadToEnd());
        var csvSource = new CsvBirdRecordsNewDbSource(streader);

        var source = new AccessBirdRecordsDbSource(null, csvSource);

        return source.Read();
    }

    private IEnumerable<BirdRecord> GetRecordsFromAccessDatabase(string filename)
    {
        var oldDbSource = new AccessBirdRecordsOldDbSource(filename, "Tab_Ring_Podab");
        var newDbSource = new AccessBirdRecordsNewDbSource(filename, "AB 2017_18_19_20_21S");

        var source = new AccessBirdRecordsDbSource(oldDbSource, newDbSource);

        return source.Read();
    }
}