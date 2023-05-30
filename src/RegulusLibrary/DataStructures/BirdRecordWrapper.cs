namespace RegulusLibrary.DataStructures;

public class BirdRecordWrapper
{
    public int Id { get; set; }
    public string? SpeciesCode { get; set; }
    public string? Sex { get; set; }
    public decimal? Wing { get; set; }
    public decimal? Tail { get; set; }
    public decimal? Weight { get; set; }
    public DateTime? DateTime { get; set; }
    public decimal? WingPopulationMean { get; set; }
    public decimal? WingPopulationStandardDeviation { get; set; }
    public decimal? TailPopulationMean { get; set; }
    public decimal? TailPopulationStandardDeviation { get; set; }
    public decimal? WeightPopulationMean { get; set; }
    public decimal? WeightPopulationStandardDeviation { get; set; }
}