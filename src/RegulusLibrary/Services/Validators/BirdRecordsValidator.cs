using RegulusLibrary.DataStructures;

namespace RegulusLibrary.Services.Validators;

public class BirdRecordsValidator : IBirdRecordsValidator
{
    public decimal TailNumberOfStandardDeviations { get; set; } = 1;
    public decimal WingNumberOfStandardDeviations { get; set; } = 1;
    public decimal WeightNumberOfStandardDeviations { get; set; } = 1;

    public bool IsValid(BirdRecordWrapper birdRecord)
    {
        if (!VerifyValue(birdRecord.Tail, birdRecord.TailPopulationMean, birdRecord.TailPopulationStandardDeviation, TailNumberOfStandardDeviations)) return false;
        if (!VerifyValue(birdRecord.Wing, birdRecord.WingPopulationMean, birdRecord.WingPopulationStandardDeviation, WingNumberOfStandardDeviations)) return false;
        if (!VerifyValue(birdRecord.Weight, birdRecord.WeightPopulationMean, birdRecord.WeightPopulationStandardDeviation, WeightNumberOfStandardDeviations)) return false;
        return true;
    }

    public bool VerifyValue(decimal? value, decimal mean, decimal standardDeviation, decimal numberOfStandardDeviations = 1)
    {
        if (value == null) return true;
        return value > 0 && value >= mean - numberOfStandardDeviations * standardDeviation && value <= mean + numberOfStandardDeviations * standardDeviation;
    }
}