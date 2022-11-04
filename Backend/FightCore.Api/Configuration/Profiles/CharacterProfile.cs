using AutoMapper;
using FightCore.Api.DataTransferObjects.Abstract;
using FightCore.Api.DataTransferObjects.Exports.Full;
using FightCore.Models;

namespace FightCore.Api.Configuration.Profiles
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {
            CreateMap<Character, BaseCharacter>();
            CreateMap<Character, FullExportCharacter>();

            CreateMap<CharacterMiscInfo, BaseCharacterMiscInfo>();
            CreateMap<CharacterStatistics, BaseCharacterStatistics>();
        }
    }
}
