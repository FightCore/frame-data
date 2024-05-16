using AutoMapper;
using FightCore.Api.DataTransferObjects.Abstract;
using FightCore.Api.DataTransferObjects.Characters;
using FightCore.Api.DataTransferObjects.Exports.Characters;
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
            CreateMap<Character, BasicExportCharacter>();
            CreateMap<Character, BasicCharacter>();
            CreateMap<Character, CharacterWithMoves>();

            CreateMap<CharacterMiscInfo, BaseCharacterMiscInfo>();
            CreateMap<CharacterStatistics, BaseCharacterStatistics>();
        }
    }
}
