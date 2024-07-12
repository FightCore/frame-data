using FightCore.Models;
using Microsoft.Data.Sqlite;
using Dapper;
using FightCore.External.MeleeDatabase.Models;

namespace FightCore.External.MeleeDatabase
{
	public class DatabaseCreator
	{
		private const string _miscCreateStatement = @"CREATE TABLE misc (
			char VARCHAR(20) NOT NULL,
			weight INTEGER,
			gravity FLOAT,
			walk_speed FLOAT,
			run_speed FLOAT,
			wd_length INTEGER,
			wd_frames INTEGER,
			jump_squat INTEGER,
			wall_jump BOOLEAN,
			notes VARCHAR(200),
			PRIMARY KEY (char),
			CHECK (wall_jump IN (0, 1))
		)";

		public static async Task Export(List<Character> export, string path)
		{
			// this creates a zero-byte file
			if (File.Exists(path))
			{
				File.Delete(path);
			}

			var connectionString = $"Data Source={path};";
			var connection = new SqliteConnection(connectionString);
			await connection.OpenAsync();

			await CreateMiscTable(export, connection);
			await CreateDodgesTable(export, connection);
			await CreateThrowsTable(export, connection);
			await CreateGrabsTable(export, connection);
			await CreateAttacksTable(export, connection);
			connection.Close();
		}

		private static async Task CreateMiscTable(List<Character> characterList, SqliteConnection connection)
		{
			await connection.ExecuteAsync(_miscCreateStatement);

			const string sql =
				@"INSERT INTO misc (char, weight, gravity, walk_speed, run_speed, wd_length, wd_frames, jump_squat, wall_jump, notes)
				VALUES ($char, $weight, $gravity, $walk_speed, $run_speed, $wd_length, $wd_frames, $jump_squat, $wall_jump, $notes)";

			foreach (var misc in characterList.Select(character => new Misc(character)).Where(misc => misc.Char != null))
			{
				await connection.ExecuteAsync(sql, new Dictionary<string, object>()
				{
					{"$char", misc.Char},
					{"$weight", misc.Weight},
					{"$gravity", misc.Gravity},
					{"$walk_speed", misc.Walk_Speed},
					{"$run_speed", misc.Run_Speed},
					{"$wd_length", misc.Wd_Length},
					{"$wd_frames", misc.Wd_Frames},
					{"$jump_squat", misc.Jump_Squat},
					{"$wall_jump", misc.Wall_Jump},
					{ "$notes", misc.Notes}
				});
			}
		}

		private static async Task CreateDodgesTable(List<Character> characters, SqliteConnection connection)
		{
			const string createTableQuery = @"CREATE TABLE dodges (
				char VARCHAR(20) NOT NULL,
				type VARCHAR(20) NOT NULL,
				start INTEGER,
				inv_end INTEGER,
				total INTEGER,
				notes VARCHAR(200),
				PRIMARY KEY (char, type)
			)";

			await connection.ExecuteAsync(createTableQuery);

			const string sql = @"INSERT INTO dodges (char, type, start, inv_end, total, notes)
			                   VALUES ($char_value, $type_value, $start_value, $inv_end_value, $total_value, $notes_value);";

			foreach (var character in characters)
			{
				foreach (var dodge in character.Moves.Where(move => DodgeKeyConverter.Keys().Contains(move.NormalizedName)).Select(move => new Dodge(character, move)))
				{
					await connection.ExecuteAsync(sql, new Dictionary<string, object>()
					{
						{"$char_value", dodge.Char},
						{"$type_value", dodge.Type},
						{"$start_value", dodge.Start},
						{"$inv_end_value", dodge.Inv_End},
						{"$total_value", dodge.Total},
						{"$notes_value", dodge.Notes},
					});
				}
			}
		}

		private static async Task CreateAttacksTable(List<Character> characters, SqliteConnection connection)
		{
			const string createTableQuery = @"CREATE TABLE attacks (
				char VARCHAR(20) NOT NULL,
				move VARCHAR(20) NOT NULL,
				start INTEGER,
				""end"" INTEGER,
				total INTEGER,
				iasa INTEGER,
				ld_fl_spec INTEGER,
				stun INTEGER,
				percent FLOAT,
				percent_weak FLOAT,
				notes VARCHAR(200),
				auto_cancel_s INTEGER,
				auto_cancel_e INTEGER,
				land_lag INTEGER,
				cancel_lag INTEGER,
				PRIMARY KEY (char, move)
			)";

			await connection.ExecuteAsync(createTableQuery);

			const string sql =
				@"INSERT INTO attacks (char, move, start, ""end"", total, iasa, ld_fl_spec, stun, percent, percent_weak, notes, auto_cancel_s, auto_cancel_e, land_lag, cancel_lag)
				VALUES ($char, $move, $start, $end, $total, $iasa, $ld_fl_spec, $stun, $percent, $percent_weak, $notes, $auto_cancel_s, $auto_cancel_e, $land_lag, $cancel_lag)";

			foreach (var character in characters.Where(character => CharacterKeyConverter.GetCharValueForNormalizedName(character.NormalizedName) != null))
			{
				foreach (var attack in character.Moves.Where(move => AttackKeyConverter.Keys().Contains(move.NormalizedName)).Select(move => new Attack(character, move)))
				{
					await connection.ExecuteAsync(sql, new Dictionary<string, object>()
					{
						{"$char", attack.Char},
						{"$move", attack.Move},
						{"$start", attack.Start},
						{"$end", attack.End},
						{"$total", attack.Total},
						{"$iasa", attack.Iasa},
						{"$ld_fl_spec", attack.Ld_Fl_Spec},
						{"$stun", attack.Stun},
						{"$percent", attack.Percent},
						{"$percent_weak", attack.Percent_Weak},
						{"$notes", attack.Notes},
						{"$auto_cancel_s", attack.Auto_cancel_s},
						{"$auto_cancel_e", attack.Auto_cancel_e},
						{"$land_lag", attack.Land_lag},
						{"$cancel_lag", attack.Cancel_lag}
					});
				}
			}
		}

		private static async Task CreateGrabsTable(List<Character> characters, SqliteConnection connection)
		{
			const string createTableQuery = @"
			CREATE TABLE grabs (
				char VARCHAR(20) NOT NULL,
				type VARCHAR(10) NOT NULL,
				start INTEGER,
				total INTEGER,
				notes VARCHAR(200),
				PRIMARY KEY (char, type)
			)";

			await connection.ExecuteAsync(createTableQuery);

			const string sql = @"INSERT INTO grabs (char, type, start, total, notes)
			                   VALUES ($char_value, $type_value, $start_value, $total_value, $notes_value);";

			foreach (var character in characters)
			{
				foreach (var grab in character.Moves.Where(move => GrabKeyConverter.Keys().Contains(move.NormalizedName)).Select(move => new Grab(character, move)))
				{
					await connection.ExecuteAsync(sql, new Dictionary<string, object>()
					{
						{"$char_value", grab.Char},
						{"$type_value", grab.Type},
						{"$start_value", grab.Start},
						{"$total_value", grab.Total},
						{"$notes_value", grab.Notes},
					});
				}
			}
		}

		private static async Task CreateThrowsTable(List<Character> characters, SqliteConnection connection)
		{
			const string createTableQuery = @"CREATE TABLE throws (
				char VARCHAR(20) NOT NULL,
				type VARCHAR(10) NOT NULL,
				start INTEGER,
				""end"" INTEGER,
				total INTEGER,
				percent FLOAT,
				notes VARCHAR(200),
				PRIMARY KEY (char, type)
			)";

			await connection.ExecuteAsync(createTableQuery);

			const string sql = @"INSERT INTO throws (char, type, start, end, total, percent, notes)
			                   VALUES ($char, $type, $start, $end, $total, $percent, $notes);";

			foreach (var character in characters)
			{
				foreach (var @throw in character.Moves.Where(move => ThrowKeyConverter.Keys().Contains(move.NormalizedName)).Select(move => new Throw(character, move)))
				{
					await connection.ExecuteAsync(sql, new Dictionary<string, object>()
					{
						{"$char", @throw.Char},
						{"$type", @throw.Type},
						{"$start", @throw.Start},
						{"$end", @throw.End},
						{"$percent", @throw.Percent},
						{"$total", @throw.Total},
						{"$notes", @throw.Notes},
					});
				}
			}
		}
	}
}


