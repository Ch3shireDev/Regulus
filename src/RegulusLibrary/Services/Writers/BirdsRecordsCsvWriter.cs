using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using RegulusLibrary.Services.Loaders;

namespace RegulusLibrary.Services.Writers;

public class BirdsRecordsCsvWriter : IBirdRecordsWriter
{
    public void WriteRecords(BirdRecordsSaverParameters parameters)
    {
        var filename = parameters.Filename;

        if (filename == null) throw new ArgumentNullException(nameof(parameters));

        var records = parameters.BirdRecords;

        var fileWriter = new StreamWriter(filename);

        var configuration = new CsvConfiguration(CultureInfo.InvariantCulture);
        using var csvWriter = new CsvWriter(fileWriter, configuration);

        csvWriter.WriteRecords(records);

        csvWriter.Flush();
        fileWriter.Flush();
    }
}