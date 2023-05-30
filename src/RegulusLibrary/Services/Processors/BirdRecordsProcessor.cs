using RegulusLibrary.DataStructures;

namespace RegulusLibrary.Services.Processors;

public class BirdRecordsProcessor : IBirdRecordsProcessor
{
    public IEnumerable<BirdRecordWrapper> Process(IEnumerable<BirdRecord> records)
    {
        foreach (var recordsGroup in records.GroupBy(r => r.SpeciesCode))
        {
            var wingMean = GetMean(recordsGroup.ToList(), r => r.Wing);
            var wingStandardDeviation = GetStandardDeviation(recordsGroup.ToList(), r => r.Wing);
            var tailMean = GetMean(recordsGroup.ToList(), r => r.Tail);
            var tailStandardDeviation = GetStandardDeviation(recordsGroup.ToList(), r => r.Tail);
            var weightMean = GetMean(recordsGroup.ToList(), r => r.Weight);
            var weightStandardDeviation = GetStandardDeviation(recordsGroup.ToList(), r => r.Weight);

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

    private static decimal GetMean(List<BirdRecord> records, Func<BirdRecord, decimal?> selector)
    {
        var list = records.Select(r => selector(r) ?? 0).Where(r => r > 0).ToArray();
        if (!list.Any()) return 0;
        return list.Average();
    }

    private static decimal GetStandardDeviation(List<BirdRecord> records, Func<BirdRecord, decimal?> selector)
    {
        var valuesList = records.Select(r => selector(r) ?? 0).Where(r => r > 0).ToArray();

        if (valuesList.Count() < 2) return 0;
        var mean = valuesList.Average();
        var sumOfSquaresOfDifferences = valuesList.Select(val => (val - mean) * (val - mean)).Sum();
        var standardDeviation = (decimal)Math.Sqrt((double)(sumOfSquaresOfDifferences / (valuesList.Count() - 1)));
        return standardDeviation;
    }
}