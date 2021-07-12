using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SmartAbp.Controllers;


namespace SmartAbp.Books
{
    [Route("api/Hooks")]
    public class HooksController : SmartAbpController
    {
        //这里添加数据service层的访问
        private readonly IBookAppService bookAppService_;
        public HooksController(IBookAppService bookAppService
            ) 
        {
            this.bookAppService_ = bookAppService;
        }

        //简单示例
        [HttpGet("crea")]
        public string Crea()
        {
            return "sadavdgasvdgafs";
        }

        //访问
        [HttpPost("creates")]
        public async Task<BookDto> creates(CreateUpdateBookDto data)
        {
            return await bookAppService_.CreateAsync(data);
        }
    }
}