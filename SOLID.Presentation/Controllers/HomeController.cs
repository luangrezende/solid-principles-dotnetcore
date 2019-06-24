using Microsoft.AspNetCore.Mvc;
using SOLID.Database;
using SOLID.Presentation.Models;
using SOLID.Services.Models;
using SOLID.Services.Services;

namespace SOLID.Presentation.Controllers
{
    public class HomeController : Controller
    {
        public readonly ContasServices contasServices;
        public HomeController(DbContextSolid context)
        {
            contasServices = new ContasServices(context);
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Contas = contasServices.ListarContas();
            return View();
        }

        [HttpGet]
        public IActionResult TransacaoConcluida(ContaModel conta)
        {
            return View(conta);
        }

        [HttpPost]
        public IActionResult Depositar(DepositarModel deposito)
        {
            var conta = contasServices.Depositar(deposito.Conta_ID, deposito.Valor);
            return RedirectToAction("TransacaoConcluida", conta);
        }

        [HttpPost]
        public IActionResult Sacar(DepositarModel deposito)
        {
            ContaModel conta = contasServices.Sacar(deposito.Conta_ID, deposito.Valor);
            return RedirectToAction("TransacaoConcluida", conta);
        }
    }
}
