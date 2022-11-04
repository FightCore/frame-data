using AutoMapper;
using FightCore.Api.DataTransferObjects.Abstract;
using FightCore.Api.DataTransferObjects.Exports.Full;
using FightCore.Models;

namespace FightCore.Api.Configuration.Profiles
{
    public class MoveProfile : Profile
    {
        public MoveProfile()
        {
            CreateMap<Move, BaseMove>();
            CreateMap<Move, FullExportMove>();
        }
    }
}
