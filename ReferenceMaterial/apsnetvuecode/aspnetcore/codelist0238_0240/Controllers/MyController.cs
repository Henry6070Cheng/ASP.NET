using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace codelist0238_0240.Controllers;

[Route("api/[controller]")]
[ApiController]
[ServiceFilter(typeof(CustomExceptionFilter))]
public class MyController : ControllerBase
{
    [HttpGet]
    public void GetUser()
    {
        throw new NotImplementedException();
    }
}
