namespace Fightcore.MeleeSearchExporter.Dto;

public class DataEntryDto
{
    public required string Title { get; set; }
    
    public required List<string> Tags { get; set; }
    
    public required DataDto Data { get; set; }
    
    public required string Image { get; set; }
}