using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using FightCore.FrameData;
using Microsoft.Extensions.Configuration;

namespace FightCore.External.HitboxLoader
{
	public class FrameDataContextFactory : IDesignTimeDbContextFactory<FrameDataContext>
	{
		public FrameDataContext CreateDbContext(string[] args)
		{
			var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
			var dbContextOptions =
				new DbContextOptionsBuilder<FrameDataContext>().UseNpgsql(configuration.GetConnectionString("DefaultConnection"));


			return new FrameDataContext(dbContextOptions.Options);
		}
	}
}
