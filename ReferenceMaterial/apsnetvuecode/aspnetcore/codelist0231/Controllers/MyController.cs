using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace codelist0231.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly IWebHostEnvironment _environment;

        public MyController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [HttpGet]
        public void DoSomething()
        {
            var environmentName = _environment.EnvironmentName;
            Console.WriteLine($"Current environment: {environmentName}");
        }

    }
}
