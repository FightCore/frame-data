namespace FightCore.Api.DataTransferObjects.Subactions;

public enum MatchTypeDto
{
    FullMatchName = 0,
    FullMatchIndex = 1,
    FuzzyMatch = 2,
    LookBack = 3,
    LookForward = 4,
    Manual = 5
}