using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace codelist0609.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MyController : ControllerBase
{
    //代码清单6-11
    [HttpGet]
    [EnableCors("AllowSpecificOrigin")] // 使用CORS策略
    public IActionResult Get()
    {
        // 处理GET请求
        return Ok("Success");
    }
}
