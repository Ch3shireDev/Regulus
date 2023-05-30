using RegulusLibrary.DataStructures;
using RegulusLibrary.Services.Sources.DataStructures;

namespace RegulusLibrary.Services.Sources;

public class AccessBirdRecordsDbSource : IBirdRecordsDbSource
{
    private readonly IBirdRecordsNewDbSource? _newDbSource;
    private readonly IBirdRecordsOldDbSource? _oldDbSource;

    public AccessBirdRecordsDbSource(IBirdRecordsOldDbSource oldDbSource, IBirdRecordsNewDbSource newDbSource)
    {
        _oldDbSource = oldDbSource;
        _newDbSource = newDbSource;
    }

    public IEnumerable<BirdRecord> Read()
    {
        var oldRecords = _oldDbSource?.Read()?.ToList() ?? new List<OldDbBirdRecord>();
        var newRecords = _newDbSource?.Read()?.ToList() ?? new List<NewDbBirdRecord>();

        var records = new List<BirdRecord>();

        foreach (var oldRecord in oldRecords)
        {
            var record = new BirdRecord
            {
                Id = oldRecord.IDR_Podab,
                SpeciesCode = oldRecord.Spec,
                Sex = oldRecord.Sex,
                Wing = Convert.ToDecimal(oldRecord.Wing),
                Tail = Convert.ToDecimal(oldRecord.Tail),
                Weight = Convert.ToDecimal(oldRecord.Mass),
                DateTime = oldRecord.DT
            };

            records.Add(record);
        }

        foreach (var newRecord in newRecords)
        {
            var record = new BirdRecord
            {
                Id = Convert.ToInt32(newRecord.IDR_Podab ?? 0),
                SpeciesCode = newRecord.SpeciesCode,
                Sex = newRecord.Sex,
                Wing = Convert.ToDecimal(newRecord.Wing),
                Tail = Convert.ToDecimal(newRecord.Tail),
                Weight = Convert.ToDecimal(newRecord.Weight),
                DateTime = newRecord.DT
            };

            records.Add(record);
        }

        return records;
    }
}