using SmartAbp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SmartAbp.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class SmartAbpController : AbpController
    {
        protected SmartAbpController()
        {
            LocalizationResource = typeof(SmartAbpResource);
        }
    }
}