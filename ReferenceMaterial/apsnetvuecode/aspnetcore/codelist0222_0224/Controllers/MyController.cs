using Microsoft.AspNetCore.Mvc;

namespace codelist0222_0224.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public MyController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public void DoSomething()
        {
            var settingValue = _configuration["SettingKey"];
            Console.WriteLine($"Setting value: {settingValue}");
        }
    }
}
