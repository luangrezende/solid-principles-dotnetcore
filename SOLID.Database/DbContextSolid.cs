using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SOLID.Database.Models;
using System.IO;

namespace SOLID.Database
{
    public class DbContextSolid : DbContext
    {
        public DbContextSolid(DbContextOptions<DbContextSolid> options) : base(options) { }

        public virtual DbSet<ContaCorrente> ContasCorrente { get; set; }
        public virtual DbSet<ContaPoupanca> ContasPoupanca{ get; set; }
        public virtual DbSet<Conta> Contas{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conta>()
             .ToTable("Contas")
             .HasDiscriminator<int>("TipoConta")
             .HasValue<ContaCorrente>(1)
             .HasValue<ContaPoupanca>(2);
        }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DbContextSolid>
    {
        public DbContextSolid CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($@"{Directory.GetCurrentDirectory()}/appsettings.json")
                .Build();
            var builder =
                new DbContextOptionsBuilder<DbContextSolid>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);

            return new DbContextSolid(builder.Options);
        }
    }
}
