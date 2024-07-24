using Newtonsoft.Json.Linq;

namespace FightCore.External.HitboxLoader
{
	public static class HitboxParser
	{
		public static object Parse(JToken jsonToken)
		{
			Console.WriteLine(jsonToken);
			return jsonToken;
		}
	}
}
