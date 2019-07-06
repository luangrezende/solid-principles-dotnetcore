using Microsoft.EntityFrameworkCore;
using SOLID.Database;
using SOLID.Models.Models;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.Repository.Repository
{
    public class UserRepository
    {
        private readonly DbContextSolid db;
        public UserRepository(DbContextSolid context) => db = context;

        //Methods
        public List<User> ToList()
        {
            return db.User.Include(acc => acc.Accounts).ToList();
        }

        public User GetById(int id)
        {
            return db.User.Find(id);
        }

        public void Insert(User user)
        {
            db.User.Add(user);
            Save();
        }

        public void Update(User user)
        {
            db.User.Attach(user);
            Save();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
