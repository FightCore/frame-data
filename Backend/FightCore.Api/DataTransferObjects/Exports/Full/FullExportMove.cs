using FightCore.Api.DataTransferObjects.Abstract;
using FightCore.Api.DataTransferObjects.Subactions;

namespace FightCore.Api.DataTransferObjects.Exports.Full
{
    public class FullExportMove : BaseMove
    {
        public List<BaseHitbox> Hitboxes { get; set; }

        public List<MoveSubactionDto> MoveSubactions { get; set; }
    }
}
