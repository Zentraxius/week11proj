using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Blockbuster.Models
{
  public class BlockbusterContextFactory : IDesignTimeDbContextFactory<BlockbusterContext>
  {

    BlockbusterContext IDesignTimeDbContextFactory<BlockbusterContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<BlockbusterContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new BlockbusterContext(builder.Options);
    }
  }
}