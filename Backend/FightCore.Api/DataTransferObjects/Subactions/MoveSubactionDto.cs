namespace FightCore.Api.DataTransferObjects.Subactions;

public class MoveSubactionDto
{
    public long Id { get; set; }

    public SubactionDto Subaction { get; set; }

    public long SubactionId { get; set; }

    public int Frame { get; set; }

    public MatchTypeDto MatchType { get; set; }
}