using FightCore.Api.DataTransferObjects.Abstract;
using FightCore.Api.DataTransferObjects.Subactions;

namespace FightCore.Api.DataTransferObjects.Exports.Full
{
    public class FullExportCharacter : BaseCharacter
    {
        public BaseCharacterMiscInfo CharacterInfo { get; set; }

        public BaseCharacterStatistics CharacterStatistics { get; set; }

        public List<FullExportMove> Moves { get; set; }

        public List<SubactionDto> Subactions { get; set; }
    }
}
