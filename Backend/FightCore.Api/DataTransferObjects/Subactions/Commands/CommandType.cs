namespace FightCore.Api.DataTransferObjects.Subactions.Commands;

public enum CommandType
{
    Script = 0,
    Unsolved = 1,
    AutoCancel = 2,
    BodyState = 3,
    Hitbox = 4,
    PartialBodyState = 5,
    Pointer = 6,
    StartLoop = 7,
    Throw = 8,
    Timer = 9,
    Visibility = 10,
}