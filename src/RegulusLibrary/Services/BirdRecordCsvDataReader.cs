using System.Globalization;
using CsvHelper;
using RegulusLibrary.DataStructures;

namespace RegulusLibrary.Services;

public class BirdRecordCsvDataReader
{
    private readonly TextReader _reader;

    public BirdRecordCsvDataReader(TextReader reader)
    {
        _reader = reader;
    }

    public IEnumerable<BirdRecord> Read()
    {
        using var csv = new CsvReader(_reader, CultureInfo.InvariantCulture);

        csv.Read();
        csv.ReadHeader();

        while (csv.Read())
        {
            var idrPodab = csv.GetField<int>("IDR_Podab");
            var speciesCode = csv.GetField<string>("Species Code");
            var englishName = csv.GetField<string>("English Name");
            var latinName = csv.GetField<string>("Latin Name");
            var sex = csv.GetField<string>("Sex");

            var wing = csv.GetField<decimal?>("Wing");
            var tail = csv.GetField<decimal?>("Tail");
            var weight = csv.GetField<decimal?>("Weight");

            var birdData = new BirdRecord
            {
                IDR_Podab = idrPodab,
                SpeciesCode = speciesCode,
                EnglishName = englishName,
                LatinName = latinName,
                Sex = sex,
                Wing = wing,
                Tail = tail,
                Weight = weight
            };

            yield return birdData;
        }
    }
}