using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace ManuMaster.Data;

public class ManuMasterEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public ManuMasterEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ManuMasterDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ManuMasterDbContext>()
            .Database
            .MigrateAsync();
    }
}
