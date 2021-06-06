using SmartAbp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SmartAbp.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(SmartAbpEntityFrameworkCoreDbMigrationsModule),
        typeof(SmartAbpApplicationContractsModule)
        )]
    public class SmartAbpDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
