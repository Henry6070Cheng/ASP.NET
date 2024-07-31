using lesson05_3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace lesson05_3.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet("StreamData")]
    public async Task<IActionResult> StreamDataAsync()
    {
        Response.Headers.Add("Content-Type", "text/event-stream");

        for (int i = 1; i <= 10; i++)
        {
            var data = $"Message {i} from server at {DateTime.Now}";
            var eventText = $"data: {data}\n\n";

            await Response.WriteAsync(eventText);
            await Response.Body.FlushAsync();

            await Task.Delay(1000); // 模拟每秒发送一次消息
        }

        return new EmptyResult();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}