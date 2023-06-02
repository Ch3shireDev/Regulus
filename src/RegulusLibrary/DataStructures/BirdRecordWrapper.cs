namespace RegulusLibrary.DataStructures;

public class BirdRecordWrapper
{
    public BirdRecordWrapper()
    {
    }

    public BirdRecordWrapper(BirdRecordWrapper birdRecord)
    {
        Id = birdRecord.Id;
        SpeciesCode = birdRecord.SpeciesCode;
        Sex = birdRecord.Sex;
        Wing = birdRecord.Wing;
        Tail = birdRecord.Tail;
        Weight = birdRecord.Weight;
        DateTime = birdRecord.DateTime;
        WingPopulationMean = birdRecord.WingPopulationMean;
        WingPopulationStandardDeviation = birdRecord.WingPopulationStandardDeviation;
        TailPopulationMean = birdRecord.TailPopulationMean;
        TailPopulationStandardDeviation = birdRecord.TailPopulationStandardDeviation;
        WeightPopulationMean = birdRecord.WeightPopulationMean;
        WeightPopulationStandardDeviation = birdRecord.WeightPopulationStandardDeviation;
        IsValid = birdRecord.IsValid;
    }

    public int Id { get; set; }
    public string? SpeciesCode { get; set; }
    public string? Sex { get; set; }
    public decimal? Wing { get; set; }
    public decimal? Tail { get; set; }
    public decimal? Weight { get; set; }
    public DateTime? DateTime { get; set; }
    public decimal WingPopulationMean { get; set; }
    public decimal WingPopulationStandardDeviation { get; set; }
    public decimal TailPopulationMean { get; set; }
    public decimal TailPopulationStandardDeviation { get; set; }
    public decimal WeightPopulationMean { get; set; }
    public decimal WeightPopulationStandardDeviation { get; set; }
    public bool IsValid { get; set; } = true;

    public void SetRecord(BirdRecordWrapper result)
    {
        Id = result.Id;
        SpeciesCode = result.SpeciesCode;
        Sex = result.Sex;
        Wing = result.Wing;
        Tail = result.Tail;
        Weight = result.Weight;
        DateTime = result.DateTime;
        WingPopulationMean = result.WingPopulationMean;
        WingPopulationStandardDeviation = result.WingPopulationStandardDeviation;
        TailPopulationMean = result.TailPopulationMean;
        TailPopulationStandardDeviation = result.TailPopulationStandardDeviation;
        WeightPopulationMean = result.WeightPopulationMean;
        WeightPopulationStandardDeviation = result.WeightPopulationStandardDeviation;
        IsValid = result.IsValid;
    }
}