using SOLID.Database;
using SOLID.Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.Repository.Repository
{
    public class AccountRepository
    {
        private readonly DbContextSolid db;
        public AccountRepository(DbContextSolid context) => db = context;

        //Methods
        public List<Account> ToList()
        {
            return db.Account.ToList();
        }

        public Account GetById(int id)
        {
            return db.Account.Find(id);
        }

        public void Insert(Account account)
        {
            db.Account.Add(account);
            Save();
        }

        public void Update(Account account)
        {
            db.Account.Attach(account);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }

    }
}
