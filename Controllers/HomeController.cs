using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOLID.Models;

namespace SOLID.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Depositar(int valor, int numeroConta)
        {
            Conta conta = VerificarConta(numeroConta);
            conta.Depositar(valor);

            return View(conta);
        }

        //Simula uma verificação de conta no banco de dados
        public Conta VerificarConta(int numeroConta)
        {
            if (numeroConta == 1)
            {
                return new ContaCorrente();
            }
            return new ContaPoupanca();
        }


    }
}
