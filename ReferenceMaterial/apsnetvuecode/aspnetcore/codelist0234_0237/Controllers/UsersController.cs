using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace codelist0234_0237.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpGet("{id}")]
    public void GetUser(int id)
    {
        Console.WriteLine(id);
    }
}
