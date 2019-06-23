using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOLID.Database;
using SOLID.Database.Models;
using SOLID.Presentation.Models;
using SOLID.Repository.Repository;
using SOLID.Repository.Services;

namespace SOLID.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbContextSolid db;
        private readonly TiposContasRepository tiposContasRepository;
        public HomeController(DbContextSolid context)
        {
            db = context;
            tiposContasRepository = new TiposContasRepository(db);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(tiposContasRepository.Listar());
        }

        [HttpPost]
        public IActionResult Depositar(DepositarModel deposito)
        {
            Debito conta = new TiposContasServices().VerificarTipoTransacao(deposito.TipoTransacao_ID);
            conta.Depositar(deposito.Valor);

            return View(conta);
        }
    }
}
