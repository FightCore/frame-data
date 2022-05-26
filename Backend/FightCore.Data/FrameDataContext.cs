using System;
using System.Collections.Generic;
using System.Text;
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

        public DbSet<Move> Move { get; set; }
    }
}
