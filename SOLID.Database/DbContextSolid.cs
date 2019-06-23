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

        public virtual DbSet<Contas> Contas { get; set; }
        public virtual DbSet<TiposTransacoes> TiposContas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contas>().ToTable("Contas");
            modelBuilder.Entity<TiposTransacoes>().ToTable("TiposContas");
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
