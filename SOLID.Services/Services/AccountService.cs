using SOLID.Database;
using SOLID.Models.Models;
using SOLID.Repository.Repository;
using System.Collections.Generic;

namespace SOLID.Services.Services
{
    public class AccountService
    {
        public readonly AccountRepository accountRepository;
        public AccountService(DbContextSolid context) => accountRepository = new AccountRepository(context);

        //Methods
        public Extract Deposit(int id, double value)
        {
            Account account = accountRepository.GetById(id);
            account.Deposit(value);
            accountRepository.Update(account);

            return GenerateExtract(id, value);
        }

        public Extract Serve(int id, double value)
        {
            Account account = accountRepository.GetById(id);
            account.Serve(value);
            accountRepository.Update(account);

            return GenerateExtract(id, value);
        }

        public List<Account> ToList()
        {
            return accountRepository.ToList();
        }

        private Extract GenerateExtract(int id, double value)
        {
            Extract extract = new Extract
            {
                Account_ID = id,
                Value = value,
            };
            extract.GenerateNumber();
            return extract;
        }
    }
}
