using Microsoft.AspNetCore.Mvc;
using Homo.Core.Constants;

namespace Homo.AuthApi
{
    [Route("v1/early-adopter")]
    public class EarlyAdopterController : ControllerBase
    {
        private readonly DBContext _dbContext;
        public EarlyAdopterController(Microsoft.AspNetCore.Hosting.IWebHostEnvironment env, DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public dynamic create([FromBody] DTOs.EarlyAdopterForm dto)
        {
            EarlyAdopterDataservice.Create(_dbContext, dto);
            return new { status = CUSTOM_RESPONSE.OK };
        }
    }
}