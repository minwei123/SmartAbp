using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace SmartAbp.Web
{
    [Dependency(ReplaceServices = true)]
    public class SmartAbpBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "SmartAbp";
    }
}
