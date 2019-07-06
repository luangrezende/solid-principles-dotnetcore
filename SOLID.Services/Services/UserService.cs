using SOLID.Database;
using SOLID.Models.Models;
using SOLID.Repository.Repository;
using System.Collections.Generic;

namespace SOLID.Services.Services
{
    public class UserService
    {
        public readonly UserRepository userRepository;
        public readonly AccountService accountService;
        public UserService(DbContextSolid context)
        {
            userRepository = new UserRepository(context);
            accountService = new AccountService(context);
        }

        //Methods
        public List<User> ToList()
        {
            return userRepository.ToList();
        }

        public void Insert(User user)
        {
            userRepository.Insert(user);
            CreateAccounts(user.ID);
        }

        private void CreateAccounts(int idUser)
        {
            accountService.CreateNewCheckingAccount(idUser);
            accountService.CreateNewSavingsAccount(idUser);
        }
    }
}
