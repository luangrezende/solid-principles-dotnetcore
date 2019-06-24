using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SOLID.Presentation.Controllers
{
    public class ContasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}