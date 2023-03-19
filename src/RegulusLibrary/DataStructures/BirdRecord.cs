namespace RegulusLibrary.DataStructures;

public record BirdRecord
{
    public int Id { get; set; }
    public string? SpeciesCode { get; set; }
    public string? Sex { get; set; }
    public double? Wing { get; set; }
    public double? Tail { get; set; }
    public double? Weight { get; set; }
}