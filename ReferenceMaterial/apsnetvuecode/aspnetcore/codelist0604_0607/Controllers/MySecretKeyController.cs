using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace codelist0604.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MySecretKeyController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public MySecretKeyController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public string Get()
        {
            var service = new MyService(_configuration);
            return service.GetSecretValue();
        }
    }
}
