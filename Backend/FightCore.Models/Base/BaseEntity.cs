using System.ComponentModel.DataAnnotations;

namespace FightCore.Models.Base
{
    public abstract class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
