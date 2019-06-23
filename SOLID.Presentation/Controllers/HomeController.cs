using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOLID.Database;
using SOLID.Database.Models;

namespace SOLID.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private DbContextSolid db;
        public HomeController(DbContextSolid source) => db = source;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Depositar(int valor, int numeroConta)
        {
            Contas conta = VerificarConta(numeroConta);
            conta.Depositar(valor);

            return View(conta);
        }

        //Simula uma verificação de conta no banco de dados
        public Contas VerificarConta(int numeroConta)
        {
            if (numeroConta == 1)
            {
                return new ContaCorrente();
            }
            return new ContaPoupanca();
        }
    }
}
