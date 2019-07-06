using Microsoft.EntityFrameworkCore;
using SOLID.Models.Models;

namespace SOLID.Database
{
    public class DbContextSolid : DbContext
    {
        public DbContextSolid(DbContextOptions<DbContextSolid> options) : base(options) { }

        public virtual DbSet<User> User { get; set; }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<CheckingAccount> CheckingAccount { get; set; }
        public virtual DbSet<SavingsAccount> SavingsAccount { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<Account>()
             .ToTable("Accounts")
             .HasDiscriminator<int>("AccountType")
             .HasValue<CheckingAccount>(1)
             .HasValue<SavingsAccount>(2);

            _ = modelBuilder.Entity<User>()
             .ToTable("Users");
        }
    }
}
