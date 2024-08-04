using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using FightCore.Models;

namespace FightCore.External.MeleeDatabase.Models
{
	internal class Attack
	{
		public string Char { get; set; }

		public string Move { get; set; }

		public int? Start { get; set; }

		public int? End { get; set; }

		public int Total { get; set; }

		public int? Iasa { get; set; }

		public int Ld_Fl_Spec { get; set; }

		public int? Stun { get; set; }

		public long? Percent { get; set; }

		public long? Percent_Weak { get; set; }

		public string Notes { get; set; }

		public int? Auto_cancel_s { get; set; }

		public int? Auto_cancel_e { get; set; }

		public int? Land_lag { get; set; }

		public int? Cancel_lag { get; set; }

		public Attack(Character character, Move move)
		{
			Hitbox strongestHitbox = null;
			Hitbox weakestHitbox = null;
			//if (move.Hitboxes.Any())
			//{
			//	strongestHitbox = move.Hitboxes.MaxBy(hitbox => hitbox.Damage);
			//	weakestHitbox = move.Hitboxes.MinBy(hitbox => hitbox.Damage);

			//	if (strongestHitbox.Damage == weakestHitbox.Damage)
			//	{
			//		weakestHitbox = null;
			//	}
			//}

			Char = CharacterKeyConverter.GetCharValueForNormalizedName(character.NormalizedName);
			Move = AttackKeyConverter.GetCharValueForNormalizedName(move.NormalizedName);
			Start = move.Start;
			End = move.End;
			Total = move.TotalFrames;
			Iasa = move.IASA;
			Ld_Fl_Spec = move.LandingFallSpecialLag ?? -1;
			Stun = strongestHitbox?.Shieldstun;
			Percent = strongestHitbox?.Damage;
			Percent_Weak = weakestHitbox?.Damage;
			Notes = move.Notes;
			Auto_cancel_s = move.AutoCancelBefore;
			Auto_cancel_e = move.AutoCancelAfter;
			Land_lag = move.LandLag;
			Cancel_lag = move.LCanceledLandLag;
		}
	}
}
