using Microsoft.AspNetCore.Mvc;

namespace lesson02_2.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}