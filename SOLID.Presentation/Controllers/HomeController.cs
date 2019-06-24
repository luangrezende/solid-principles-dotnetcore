using Microsoft.AspNetCore.Mvc;
using SOLID.Database;
using SOLID.Database.Models;
using SOLID.Presentation.Models;
using SOLID.Repository.Repository;

namespace SOLID.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbContextSolid db;
        private readonly ContasRepository contasRepository;
        public HomeController(DbContextSolid context)
        {
            db = context;
            contasRepository = new ContasRepository(db);
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Contas = contasRepository.Listar();
            return View();
        }

        [HttpPost]
        public IActionResult Depositar(DepositarModel deposito)
        {
            Conta conta = contasRepository.BuscarPorId(deposito.Conta_ID);
            conta.Depositar(deposito.Valor);

            contasRepository.Atualizar(conta);

            return View("TransacaoConcluida", conta);
        }

        [HttpPost]
        public IActionResult Sacar(DepositarModel deposito)
        {
            Conta conta = contasRepository.BuscarPorId(deposito.Conta_ID);
            conta.Sacar(deposito.Valor);

            contasRepository.Atualizar(conta);

            return View("TransacaoConcluida", conta);
        }
    }
}
