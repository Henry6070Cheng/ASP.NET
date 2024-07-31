using codelist0601_0612.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;

namespace codelist0601_0612.Controllers
{
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

        //代码清单6-3
        [Authorize(Roles = "Admin")]
        public IActionResult AdminDashboard()
        {
            // 只有具有Admin角色的用户才能访问该动作方法
            return View();
        }

        [Authorize(Roles = "General")]
        public IActionResult GeneralDashboard()
        {
            // 只有具有General角色的用户才能访问该动作方法
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}