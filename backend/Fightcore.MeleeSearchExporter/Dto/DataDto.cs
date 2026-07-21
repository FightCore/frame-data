namespace Fightcore.MeleeSearchExporter.Dto;

public class DataDto
{
    // Data required for the URL to work
    public required long MoveId { get; set; }
    
    public required string NormalizedMoveName { get; set; }
    
    public required long CharacterId { get; set; }
    
    public required string NormalizedCharacterName { get; set; }
    
    public required int? Start { get; set; }
    
    public required int? End { get; set; }
    
    public required int? IASA { get; set; }
    
    public required int? TotalFrames { get; set; }
    
    public required long[]? Damage { get; set; }
    
    public required long[]? BaseKnockback { get; set; }
    
    public required long[]? KnockbackGrowth { get; set; }
    
    public required long[]? SetKnockback { get; set; }
    
    public required long[]? Angle { get; set; }
    
    public required string Notes { get; set; }
    
    public required int? AutoCancelBefore { get; set; }
    
    public required int? AutoCancelAfter { get; set; }
    
    public required int? LandLag { get; set; }
    
    public required int? LCancelledLandLag { get; set; }
    
    public required string Character { get; set; }
    
    public required string Move { get; set; }
}