using Microsoft.AspNetCore.Mvc;
using SOLID.Database;
using SOLID.Database.Models;
using SOLID.Presentation.Models;
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

        [HttpPost]
        public IActionResult Depositar(DepositarModel deposito)
        {
            Conta conta = contasServices.Depositar(deposito.Conta_ID, deposito.Valor);
            return View("TransacaoConcluida", conta);
        }

        [HttpPost]
        public IActionResult Sacar(DepositarModel deposito)
        {
            Conta conta = contasServices.Sacar(deposito.Conta_ID, deposito.Valor);
            return View("TransacaoConcluida", conta);
        }
    }
}
