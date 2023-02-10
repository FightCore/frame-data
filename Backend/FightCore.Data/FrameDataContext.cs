using FightCore.Models;
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
    }
}
