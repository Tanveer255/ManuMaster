using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ManuMaster.Data;

public class ManuMasterDbContextFactory : IDesignTimeDbContextFactory<ManuMasterDbContext>
{
    public ManuMasterDbContext CreateDbContext(string[] args)
    {

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ManuMasterDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new ManuMasterDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
