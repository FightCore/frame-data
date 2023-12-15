using AutoMapper;
using FightCore.Api.DataTransferObjects.Subactions;
using FightCore.Api.DataTransferObjects.Subactions.Commands;
using FightCore.Models.Subactions;
using FightCore.Models.Subactions.Commands;
using MatchType = FightCore.Models.Subactions.MatchType;

namespace FightCore.Api.Configuration.Profiles
{
	public class SubactionProfile : Profile
	{
		public SubactionProfile()
		{
			CreateMap<Subaction, SubactionDto>();
			CreateMap<ScriptCommand, ScriptCommandDto>().IncludeAllDerived();
			CreateMap<AutoCancelCommand, AutoCancelCommandDto>().IncludeBase<ScriptCommand, ScriptCommandDto>();
			CreateMap<BodyStateCommand, BodyStateCommandDto>().IncludeBase<ScriptCommand, ScriptCommandDto>();
			CreateMap<BodyType, BodyTypeDto>();
			CreateMap<ElementType, ElementTypeDto>();
			CreateMap<HitboxCommand, HitboxCommandDto>().IncludeBase<ScriptCommand, ScriptCommandDto>();
			CreateMap<HurtboxInteractionFlags, HurtboxInteractionFlagsDto>();
			CreateMap<PartialBodystateCommand, PartialBodystateCommandDto>().IncludeBase<ScriptCommand, ScriptCommandDto>();
			CreateMap<PointerCommand, PointerCommandDto>().IncludeBase<ScriptCommand, ScriptCommandDto>();
			CreateMap<StartLoopCommand, StartLoopCommandDto>().IncludeBase<ScriptCommand, ScriptCommandDto>();
			CreateMap<ThrowCommand, ThrowCommandDto>().IncludeBase<ScriptCommand, ScriptCommandDto>();
			CreateMap<ThrowElementType, ThrowElementTypeDto>();
			CreateMap<ThrowType, ThrowTypeDto>();
			CreateMap<TimerCommand, TimerCommandDto>().IncludeBase<ScriptCommand, ScriptCommandDto>();
			CreateMap<UnsolvedCommand, UnsolvedCommandDto>().IncludeBase<ScriptCommand, ScriptCommandDto>();
			CreateMap<VisibilityCommand, VisibilityCommandDto>().IncludeBase<ScriptCommand, ScriptCommandDto>();
			CreateMap<VisibilityConstant, VisibilityConstantDto>();
			CreateMap<MatchType, MatchTypeDto>();
			CreateMap<MoveSubaction, MoveSubactionDto>();
			CreateMap<SubactionHeader, SubactionHeaderDto>();
		}
	}
}
