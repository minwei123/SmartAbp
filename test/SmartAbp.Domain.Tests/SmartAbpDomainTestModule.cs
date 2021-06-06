using SmartAbp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SmartAbp
{
    [DependsOn(
        typeof(SmartAbpEntityFrameworkCoreTestModule)
        )]
    public class SmartAbpDomainTestModule : AbpModule
    {

    }
}