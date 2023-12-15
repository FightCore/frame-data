using FightCore.Api.DataTransferObjects.Abstract;

namespace FightCore.Api.DataTransferObjects.Exports.Characters
{
	public class BasicExportCharacter : BaseCharacter
	{
		public BaseCharacterMiscInfo CharacterInfo { get; set; }

		public BaseCharacterStatistics CharacterStatistics { get; set; }
	}
}
