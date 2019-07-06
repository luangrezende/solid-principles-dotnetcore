using Microsoft.EntityFrameworkCore;
using SOLID.Database.Models;

namespace SOLID.Database
{
    public class DbContextSolid : DbContext
    {
        public DbContextSolid(DbContextOptions<DbContextSolid> options) : base(options) { }

        public virtual DbSet<ContaCorrente> ContasCorrente { get; set; }
        public virtual DbSet<ContaPoupanca> ContasPoupanca { get; set; }
        public virtual DbSet<Conta> Contas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<Conta>()
             .ToTable("Contas")
             .HasDiscriminator<int>("TipoConta")
             .HasValue<ContaCorrente>(1)
             .HasValue<ContaPoupanca>(2);
        }
    }
}
