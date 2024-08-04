using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
				new DbContextOptionsBuilder<FrameDataContext>().UseSqlServer(configuration.GetConnectionString("DefaultConnection"));


			return new FrameDataContext(dbContextOptions.Options);
		}
	}
}
