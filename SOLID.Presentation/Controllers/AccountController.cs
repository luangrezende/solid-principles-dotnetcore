using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SOLID.Database;
using SOLID.Models.Models;
using SOLID.Services.Models;
using SOLID.Services.Services;

namespace SOLID.Presentation.Controllers
{
    public class AccountController : Controller
    {
        public readonly AccountService accountService;
        public AccountController(DbContextSolid context) => accountService = new AccountService(context);

        //Methods
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Accounts = new SelectList(accountService.ToList(), "ID", "Balance");
            return View();
        }

        [HttpGet]
        public IActionResult TransactionSuccess(Extract account)
        {
            return View(account);
        }

        [HttpPost]
        public IActionResult Deposit(TransationModel transaction)
        {
            Extract account = accountService.Deposit(transaction.Account_ID, transaction.Value);
            return RedirectToAction("TransactionSuccess", account);
        }

        [HttpPost]
        public IActionResult Serve(TransationModel transaction)
        {
            Extract account = accountService.Serve(transaction.Account_ID, transaction.Value);
            return RedirectToAction("TransactionSuccess", account);
        }
    }
}