using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace SmartAbp.EntityFrameworkCore
{
    [DependsOn(
        typeof(SmartAbpEntityFrameworkCoreModule)
        )]
    public class SmartAbpEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<SmartAbpMigrationsDbContext>();
        }
    }
}
