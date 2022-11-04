using FightCore.Api.DataTransferObjects.Abstract;

namespace FightCore.Api.DataTransferObjects.Exports.Full
{
    public class FullExportCharacter : BaseCharacter
    {
        public BaseCharacterMiscInfo CharacterInfo { get; set; }

        public BaseCharacterStatistics CharacterStatistics { get; set; }

        public List<FullExportMove> Moves { get; set; }
    }
}
