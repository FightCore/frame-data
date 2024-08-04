using FightCore.Models;

namespace FightCore.Exporters
{
	public class MoveListExport : Move
	{
		public string CharacterName { get; set; }
		public string NormalizedCharacterName { get; set; }

		public MoveListExport(Move move, string characterName, string normalizedCharacterName, long characterId)
		{
			Id = move.Id;
			Name = move.Name;
			NormalizedName = move.NormalizedName;
			NormalizedCharacterName = normalizedCharacterName;
            LandLag = move.LandLag;
			LCanceledLandLag = move.LCanceledLandLag;
			LandingFallSpecialLag = move.LandingFallSpecialLag;
			TotalFrames = move.TotalFrames;
			IASA = move.IASA;
			AutoCancelAfter = move.AutoCancelAfter;
			AutoCancelBefore = move.AutoCancelBefore;
			Start = move.Start;
			End = move.End;
			Type = move.Type;
			Notes = move.Notes;
			Percent = move.Percent;
			GifUrl = move.GifUrl;
			IsInterpolated = move.IsInterpolated;

			CharacterName = characterName;
			CharacterId = characterId;
		}
	}
}
