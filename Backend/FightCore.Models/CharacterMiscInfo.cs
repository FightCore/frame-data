using System.ComponentModel.DataAnnotations;

namespace FightCore.Models
{
    public class CharacterMiscInfo
    {
        [Key]
        public long Id { get; set; }

        public string Discord { get; set; }

        public string MeleeFrameData { get; set; }

        public string SsbWiki { get; set; }
    }
}
