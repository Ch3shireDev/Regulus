using RegulusLibrary.DataStructures;

namespace RegulusLibrary.Services.Loaders;

public class BirdRecordsSaverParameters
{
    public string? Filename { get; set; }
    public List<BirdRecord> BirdRecords { get; set; } = new List<BirdRecord>();
}