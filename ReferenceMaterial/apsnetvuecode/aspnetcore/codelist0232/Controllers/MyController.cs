using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace codelist0232.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly ILogger<MyController> _logger;

        public MyController(ILogger<MyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void DoSomething()
        {
            _logger.LogInformation("Doing something...");

            try
            {
                // 执行操作
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while doing something.");
            }
        }

    }
}
