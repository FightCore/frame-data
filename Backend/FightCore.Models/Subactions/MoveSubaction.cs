namespace FightCore.Models.Subactions;

public class MoveSubaction
{
    public long Id { get; set; }

    public Move Move { get; set; }

    public long MoveId { get; set; }

    public Subaction Subaction { get; set; }

    public long SubactionId { get; set; }

    public int Frame { get; set; }

    public MatchType MatchType { get; set; }
}