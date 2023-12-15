using FightCore.Models;
using FightCore.Models.Subactions;
using FightCore.Models.Subactions.Commands;
using Microsoft.EntityFrameworkCore;

namespace FightCore.FrameData
{
    public class FrameDataContext : DbContext
    {
        public FrameDataContext(DbContextOptions<FrameDataContext> options) : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Move> Moves { get; set; }

        public DbSet<Hitbox> Hitboxes { get; set; }

        public DbSet<CharacterMiscInfo> CharactersMiscInfos { get; set; }

        public DbSet<CharacterStatistics> CharacterStatistics { get; set; }

        public DbSet<MoveSubaction> MoveSubactions { get; set; }

        public DbSet<Subaction> Subactions { get; set; }

        public DbSet<ScriptCommand> ScriptCommands { get; set; }

        public DbSet<AutoCancelCommand> AutoCancelCommands { get; set; }

        public DbSet<BodyStateCommand> BodyStateCommands { get; set; }

        public DbSet<HitboxCommand> HitboxCommands { get; set; }

        public DbSet<PartialBodystateCommand> PartialBodystateCommands { get; set; }

        public DbSet<PointerCommand> PointerCommands { get; set; }

        public DbSet<StartLoopCommand> StartLoopCommands { get; set; }

        public DbSet<ThrowCommand> ThrowCommands { get; set; }

        public DbSet<TimerCommand> TimerCommands { get; set; }

        public DbSet<UnsolvedCommand> UnsolvedCommands { get; set; }

        public DbSet<VisibilityCommand> VisibilityCommands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
	        base.OnModelCreating(modelBuilder);
	        modelBuilder.Entity<ScriptCommand>().UseTptMappingStrategy();
        }
    }
}
