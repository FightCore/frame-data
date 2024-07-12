using FightCore.Models.Base;
using FightCore.Models.Subactions;

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

        public long FightCoreId { get; set; }

        public List<Move> Moves { get; set; }

        public CharacterStatistics CharacterStatistics { get; set; }

        public CharacterMiscInfo CharacterInfo { get; set; }

        public List<Subaction> Subactions { get; set; }
    }
}
