using Microsoft.AspNetCore.Mvc;
using SOLID.Database;
using SOLID.Models.Models;
using SOLID.Services.Services;
using System.Collections.Generic;

namespace SOLID.Presentation.Controllers
{
    public class UserController : Controller
    {
        public readonly UserService userService;
        public UserController(DbContextSolid context) => userService = new UserService(context);

        //Methods
        [HttpGet]
        public IActionResult Index()
        {
            List<User> users = userService.ToList();
            return View(users);
        }

        [HttpGet]
        public IActionResult UserCreated(User user)
        {
            return View(user);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            userService.Insert(user);
            return RedirectToAction("UserCreated", user);
        }
    }
}