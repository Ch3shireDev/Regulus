namespace RegulusLibrary.DataStructures;

public record BirdRecord
{
    public int Id { get; set; }
    public string? SpeciesCode { get; set; }
    public string? Sex { get; set; }
    public decimal? Wing { get; set; }
    public decimal? Tail { get; set; }
    public decimal? Weight { get; set; }
    public DateTime? DateTime { get; set; }
}