namespace FightCore.Api.DataTransferObjects.Abstract
{
    public class BaseCharacterStatistics
    {
        public long Id { get; set; }

        public int Weight { get; set; }

        public double Gravity { get; set; }

        public double WalkSpeed { get; set; }

        public double RunSpeed { get; set; }

        public int WaveDashLengthRank { get; set; }

        public int PLAIntangibilityFrames { get; set; }

        public int JumpSquat { get; set; }

        public bool CanWallJump { get; set; }

        public string Notes { get; set; }

        public double InitialDash { get; set; }

        public int DashFrames { get; set; }

        public double WaveDashLength { get; set; }
    }
}
