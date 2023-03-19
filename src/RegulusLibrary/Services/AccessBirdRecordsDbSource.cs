using RegulusLibrary.DataStructures;
using RegulusLibrary.Services.Sources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegulusLibrary.Services
{
    public class AccessBirdRecordsDbSource
    {
        private readonly IBirdRecordsOldDbSource _oldDbSource;
        private readonly IBirdRecordsNewDbSource _newDbSource;

        public AccessBirdRecordsDbSource(IBirdRecordsOldDbSource oldDbSource, IBirdRecordsNewDbSource newDbSource)
        {
            _oldDbSource = oldDbSource;
            _newDbSource = newDbSource;
        }

        public IEnumerable<BirdRecord> Read()
        {
            var oldRecords = _oldDbSource.Read().ToList();
            var newRecords = _newDbSource.Read().ToList();

            var records = new List<BirdRecord>();

            foreach (var oldRecord in oldRecords)
            {
                var record = new BirdRecord
                {
                    Id = oldRecord.IDR_Podab,
                    SpeciesCode = oldRecord.Spec,
                    Sex = oldRecord.Sex,
                    Wing = oldRecord.Wing,
                    Tail = oldRecord.Tail,
                    Weight = oldRecord.Mass
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
                    Wing = newRecord.Wing,
                    Tail = newRecord.Tail,
                    Weight = newRecord.Weight
                };

                records.Add(record);
            }

            return records;
        }
    }
}
