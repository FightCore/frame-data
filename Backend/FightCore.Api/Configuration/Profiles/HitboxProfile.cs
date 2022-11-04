using AutoMapper;
using FightCore.Api.DataTransferObjects.Abstract;
using FightCore.Models;

namespace FightCore.Api.Configuration.Profiles
{
    public class HitboxProfile : Profile
    {
        public HitboxProfile()
        {
            CreateMap<Hitbox, BaseHitbox>();
        }
    }
}
