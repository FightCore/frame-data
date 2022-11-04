using FightCore.Api.DataTransferObjects.Abstract;

namespace FightCore.Api.DataTransferObjects.Exports.Full
{
    public class FullExportMove : BaseMove
    {
        public List<BaseHitbox> Hitboxes { get; set; }
    }
}
