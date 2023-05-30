using RegulusLibrary.DataStructures;

namespace RegulusLibrary.Services.Processors;

public class BirdRecordsProcessor : IBirdRecordsProcessor
{
    public IEnumerable<BirdRecordWrapper> Process(IEnumerable<BirdRecord> records)
    {
        foreach (var recordsGroup in records.GroupBy(r => r.SpeciesCode))
        {
            var wingMean = recordsGroup.Average(r => r.Wing);
            var wingStandardDeviation = CalculateStandardDeviation(recordsGroup.ToList().Select(r => r.Wing ?? 0).Where(w => w > 0));
            var tailMean = recordsGroup.Average(r => r.Tail);
            var tailStandardDeviation = CalculateStandardDeviation(recordsGroup.ToList().Select(r => r.Tail ?? 0).Where(w => w > 0));
            var weightMean = recordsGroup.Average(r => r.Weight);
            var weightStandardDeviation = CalculateStandardDeviation(recordsGroup.ToList().Select(r => r.Weight ?? 0).Where(w => w > 0));

            foreach (var recordWrapper in recordsGroup)
            {
                var record = new BirdRecordWrapper
                {
                    Id = recordWrapper.Id,
                    SpeciesCode = recordWrapper.SpeciesCode,
                    Sex = recordWrapper.Sex,
                    Wing = recordWrapper.Wing,
                    Tail = recordWrapper.Tail,
                    Weight = recordWrapper.Weight,
                    DateTime = recordWrapper.DateTime,
                    WingPopulationMean = wingMean,
                    WingPopulationStandardDeviation = wingStandardDeviation,
                    TailPopulationMean = tailMean,
                    TailPopulationStandardDeviation = tailStandardDeviation,
                    WeightPopulationMean = weightMean,
                    WeightPopulationStandardDeviation = weightStandardDeviation
                };


                yield return record;
            }
        }
    }


    public static decimal CalculateStandardDeviation(IEnumerable<decimal> value)
    {
        var valuesList = value.ToList();
        if (valuesList.Count < 2) return 0;
        var mean = valuesList.Average();
        var sumOfSquaresOfDifferences = valuesList.Select(val => (val - mean) * (val - mean)).Sum();
        var standardDeviation = (decimal)Math.Sqrt((double)(sumOfSquaresOfDifferences / (valuesList.Count - 1)));
        return standardDeviation;
    }
}