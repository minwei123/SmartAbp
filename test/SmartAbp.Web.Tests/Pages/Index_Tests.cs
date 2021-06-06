using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace SmartAbp.Pages
{
    public class Index_Tests : SmartAbpWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
