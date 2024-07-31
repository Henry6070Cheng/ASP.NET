using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace codelist0212_0214.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly IMyService _myService;
        public MyController(IMyService myService)
        {
            _myService = myService;
        }

        [HttpGet]
        public void Index()
        {
            _myService.DoSomething();
        }
    }
}
