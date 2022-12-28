using FightCore.Api.DataTransferObjects.Abstract;

namespace FightCore.Api.DataTransferObjects.Characters
{
    public class CharacterWithMoves : BasicCharacter
    {
        public List<BaseMove> Moves { get; set; }
    }
}
