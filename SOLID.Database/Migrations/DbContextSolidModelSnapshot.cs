﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SOLID.Database;

namespace SOLID.Database.Migrations
{
    [DbContext(typeof(DbContextSolid))]
    partial class DbContextSolidModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SOLID.Database.Models.Conta", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.Property<double>("Saldo");

                    b.Property<int>("TipoConta");

                    b.HasKey("ID");

                    b.ToTable("Contas");

                    b.HasDiscriminator<int>("TipoConta");
                });

            modelBuilder.Entity("SOLID.Database.Models.ContaCorrente", b =>
                {
                    b.HasBaseType("SOLID.Database.Models.Conta");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("SOLID.Database.Models.ContaPoupanca", b =>
                {
                    b.HasBaseType("SOLID.Database.Models.Conta");

                    b.HasDiscriminator().HasValue(2);
                });
#pragma warning restore 612, 618
        }
    }
}
