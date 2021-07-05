using SmartAbp.Localization;
using Volo.Abp.AspNetCore.Mvc;
using SmartAbp.Books;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SmartAbp.Controllers;

namespace SmartAbp.HooksController
{
    [Route("api/Hooks")]
    public class HooksController : SmartAbpController
    {

        [HttpGet("crea")]
        public string Crea()
        {
            return "sadavdgasvdgafs";
        }
    }
}