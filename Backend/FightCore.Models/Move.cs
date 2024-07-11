using FightCore.Models.Base;
using FightCore.Models.Subactions;

namespace FightCore.Models
{
    public class Move : BaseEntity
    {
        public string Name { get; set; }

        public string NormalizedName { get; set; }

        public List<Hitbox> Hitboxes { get; set; }

        public int? LandLag { get; set; }

        public int? LCanceledLandLag { get; set; }

        public int? LandingFallSpecialLag { get; set; }

        public int TotalFrames { get; set; }

        public int? IASA { get; set; }

        public int? AutoCancelBefore { get; set; }

        public int? AutoCancelAfter { get; set; }

        public int? Start { get; set; }

        public int? End { get; set; }

        public MoveType Type { get; set; }

        public string Notes { get; set; }

        public int? Percent { get; set; }

        public long CharacterId { get; set; }

        public Character Character { get; set; }

        // This will be deprecated soon for Sources.
        public string Source { get; set; }

        public string GifUrl { get; set; }

        public bool IsInterpolated { get; set; }

        public List<MoveSubaction> MoveSubactions { get; set; }

        public List<Source> Sources { get; set; }
	}
}
