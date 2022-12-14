using Microsoft.AspNetCore.Mvc;
using Homo.Core.Constants;

namespace Homo.Api
{
    [Route("v1/test")]
    public class TestController : ControllerBase
    {
        public TestController(Microsoft.AspNetCore.Hosting.IWebHostEnvironment env)
        {
        }

        [HttpGet]
        public dynamic getTest()
        {
            return new { project = "Notify2 Api 6" };
        }

        [HttpPost]
        [Validate]
        public dynamic postTest([FromBody] DTOs.Test dto)
        {
            return new { status = CUSTOM_RESPONSE.OK };
        }
    }
}
