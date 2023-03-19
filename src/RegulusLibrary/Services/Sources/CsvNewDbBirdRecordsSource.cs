using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using RegulusLibrary.Services.Sources.DataStructures;

namespace RegulusLibrary.Services.Sources;

public class CsvNewDbBirdRecordsSource:INewDbBirdRecordsSource
{
   public StringReader? StringReader{ get; set; }

    public CsvNewDbBirdRecordsSource(StringReader stringReader)
    {
        this.StringReader = stringReader;
    }

    public CsvNewDbBirdRecordsSource(){}

    public IEnumerable<NewDbBirdRecord> Read()
    {
        var configuration = new CsvConfiguration(CultureInfo.InvariantCulture);
        using var csvReader = new CsvReader(StringReader, configuration);

        csvReader.Context.TypeConverterOptionsCache.GetOptions<string>().NullValues.Add("NULL");
        csvReader.Context.TypeConverterOptionsCache.GetOptions<double?>().NullValues.Add("NULL");
        csvReader.Context.TypeConverterOptionsCache.GetOptions<DateTime?>().NullValues.AddRange(new[] { "NULL", "0" });
        csvReader.Context.TypeConverterOptionsCache.GetOptions<int?>().NullValues.Add("NULL");

        var records = csvReader.GetRecords<NewDbBirdRecord>().ToList();
        return records;
    }
}