using CsvHelper.Configuration;
using CsvHelper;
using Newtonsoft.Json;
using System.Collections;
using System.Globalization;
using Newtonsoft.Json.Serialization;

namespace FightCore.Exporters
{
	public static class Exporter
	{
		private static readonly DefaultContractResolver _contractResolver = new()
		{
			NamingStrategy = new CamelCaseNamingStrategy()
		};

		private static readonly JsonSerializerSettings _noNestedJsonSettings = new()
		{
			Formatting = Formatting.None,
			ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
			ContractResolver = _contractResolver
		};

		public static async Task Export(IEnumerable toExport, string folder, string name)
		{
			await ExportJson(toExport, folder, name);
			await ExportCsv(toExport, folder, name);
		}

		public static async Task ExportCsv(IEnumerable toExport, string folder, string name)
		{
			if (!Directory.Exists(folder))
			{
				Directory.CreateDirectory(folder);
			}
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

		public static Task ExportJson(object toExport, string folder, string name)
		{
			if (!Directory.Exists(folder))
			{
				Directory.CreateDirectory(folder);
			}

			var json = JsonConvert.SerializeObject(toExport, _noNestedJsonSettings);
			var jsonPath = Path.Combine(folder, $"{name}.json");
			Console.WriteLine($"Writing to {jsonPath}");
			return File.WriteAllTextAsync(jsonPath, json);


		}
	}
}
