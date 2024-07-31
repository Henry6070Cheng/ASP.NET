using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace codelist0225_0229.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    private readonly MyConfigOptions _myConfig;

    public HomeController(IOptions<MyConfigOptions> myConfig)
    {
        _myConfig = myConfig.Value;
    }

    [HttpGet]
    public void Index()
    {
        Console.WriteLine("Key1:" + _myConfig.Key1);
        Console.WriteLine("Key2:" + _myConfig.Key2);
    }

}
