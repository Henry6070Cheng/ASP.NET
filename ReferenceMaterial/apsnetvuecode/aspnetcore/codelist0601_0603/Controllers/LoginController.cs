using codelist0601_0612.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace codelist0601_0612.Controllers;

public class LoginController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    //代码清单6-1
    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            // 在此编写身份验证逻辑
            if (IsValidUser(model.Username, model.Password))
            {
                // 用户验证成功
                // 创建会话并将用户标识存储在会话中
                HttpContext.Session.SetString("UserId", model.Username);

                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                if (model.Username.ToLower() == "admin")
                {
                    identity.AddClaims(new[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, model.Username),
                        // 添加角色Admin
                        new Claim(ClaimTypes.Role, "Admin")
                    });
                }
                else if (model.Username.ToLower() == "general")
                {
                    identity.AddClaims(new[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, model.Username),
                        // 添加角色General
                        new Claim(ClaimTypes.Role, "General")
                    });
                }

                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "无效的用户名或密码");
        }

        return View(model);
    }

    private bool IsValidUser(string username, string password)
    {
        return true;
        // 在此编写用户名和密码的验证逻辑
        // 返回true或false
    }

}
