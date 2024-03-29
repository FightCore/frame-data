﻿using FightCore.Models.Base;

namespace FightCore.Models
{
    public class Character : BaseEntity
    {
        public string Name { get; set; }

        /// <summary>
        /// This is the name, normalized to use upper case and removed the special characters.
        /// This is meant to be used for users to search.
        /// </summary>
        public string NormalizedName { get; set; }

        [Obsolete]
        public long FightCoreId { get; set; }

        public List<Move> Moves { get; set; }

        public CharacterStatistics CharacterStatistics { get; set; }

        public CharacterMiscInfo CharacterInfo { get; set; }
    }
}
