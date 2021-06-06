using SmartAbp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace SmartAbp.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class SmartAbpPageModel : AbpPageModel
    {
        protected SmartAbpPageModel()
        {
            LocalizationResourceType = typeof(SmartAbpResource);
        }
    }
}