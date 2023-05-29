using RegulusLibrary.Services.Loaders;

namespace RegulusLibrary.Services.Writers;

public interface IBirdRecordsWriter
{
    void WriteRecords(BirdRecordsSaverParameters parameters);
}