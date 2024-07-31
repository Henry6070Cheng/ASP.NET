using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace codelist1501.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly IList<UserModel> users;
    private readonly ILogger<UsersController> _logger;

    public UsersController(ILogger<UsersController> logger)
    {
        _logger = logger;
        users = new List<UserModel>();
        for (int i = 1; i < 10; i++)
        {
            users.Add(new UserModel()
            {
                Id = i,
                Name = $"John{i}",
                Email = $"John{i}@163.com"
            });
        }
    }

    [HttpGet]
    public IList<UserModel> GetUsers()
    {
        return users;
    }

    [HttpPost]
    public IList<UserModel> PostUsers(UserModel input)
    {
        users.Add(new UserModel()
        {
            Id = users.Max(x=>x.Id)+1,
            Name = input.Name,
            Email = input.Email
        });
        Console.WriteLine($"Name:{input.Name},Email:{input.Email}");
        return users;
    }

    [HttpPut("{id}")]
    public IList<UserModel> PostUsers(int id, UserModel input)
    {
        var item = users.First(x => x.Id == id);
        item.Name = input.Name;
        item.Email = input.Email;
        Console.WriteLine($"Id:{id},Name:{input.Name},Email:{input.Email}");
        return users;
    }
}