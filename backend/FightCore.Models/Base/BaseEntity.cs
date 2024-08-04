using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace FightCore.Models.Base
{
    public abstract class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
