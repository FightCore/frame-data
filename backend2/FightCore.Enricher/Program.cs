using FightCore.FrameData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RestSharp;

var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var dbContextOptions =
	new DbContextOptionsBuilder<FrameDataContext>().UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
var dbContext = new FrameDataContext(dbContextOptions.Options);

//var sources = await dbContext.Sources.ToListAsync();

var moves = await dbContext.Moves.Include(move => move.Character).ToListAsync();
var restClient = new RestClient("https://i.fightcore.gg");
RestRequest request;
RestResponse response;
foreach (var move in moves.Where(move => string.IsNullOrEmpty(move.GifUrl)))
{
	try
	{
		request = new RestRequest($"beta/{move.Character.NormalizedName}/{move.NormalizedName}.gif");
		response = await restClient.GetAsync(request);
		if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
		{
			throw new Exception();
		}

		move.GifUrl = response.ResponseUri.ToString();
		//move.Sources = sources;
		dbContext.Update(move);
		await dbContext.SaveChangesAsync();
		Console.WriteLine("Found {0} - {1}", move.Character.Name, move.Name);
		Thread.Sleep(50);
	}
	catch
	{
		Console.WriteLine("Not Found {0} - {1}", move.Character.Name, move.Name);
		Thread.Sleep(50);

	}
}