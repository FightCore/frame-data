using CsvHelper.Configuration;
using CsvHelper;
using Newtonsoft.Json;
using System.Collections;
using System.Globalization;

namespace FightCore.Exporters
{
	public static class Exporter
	{
		private static readonly JsonSerializerSettings _noNestedJsonSettings = new()
		{
			Formatting = Formatting.None,
			ReferenceLoopHandling = ReferenceLoopHandling.Ignore
		};

		public static async Task Export(IEnumerable toExport, string folder, string name)
		{
			if (!Directory.Exists(folder))
			{
				Directory.CreateDirectory(folder);
			}

			var movesJson = JsonConvert.SerializeObject(toExport, _noNestedJsonSettings);
			var jsonPath = Path.Combine(folder, $"{name}.json");
			Console.WriteLine($"Writing to {jsonPath}");
			await File.WriteAllTextAsync(jsonPath, movesJson);

			var csvPath = Path.Combine(folder, $"{name}.csv");
			await using var writer = new StreamWriter(csvPath, false);
			await using var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)
			{
				UseNewObjectForNullReferenceMembers = false,
				IgnoreReferences = true
			});

			Console.WriteLine($"Writing to {csvPath}");

			await csv.WriteRecordsAsync(toExport);
		}
	}
}
