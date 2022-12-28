using FightCore.Api.DataTransferObjects.Abstract;

namespace FightCore.Api.DataTransferObjects.Characters
{
    public class BasicCharacter : BaseCharacter
    {
        public BaseCharacterMiscInfo CharacterInfo { get; set; }

        public BaseCharacterStatistics CharacterStatistics { get; set; }
    }
}
