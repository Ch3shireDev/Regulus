namespace RegulusLibrary.DataStructures;

public record BirdRecord
{
    public int IDR_Podab { get; set; }
    public string? SpeciesCode { get; set; }
    public string? EnglishName { get; set; }
    public string? LatinName { get; set; }
    public string? Sex { get; set; }
    public decimal? Wing { get; set; }
    public decimal? Tail { get; set; }
    public decimal? Weight { get; set; }
}