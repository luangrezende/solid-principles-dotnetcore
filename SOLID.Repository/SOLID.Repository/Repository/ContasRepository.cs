using Microsoft.EntityFrameworkCore;
using SOLID.Database;
using SOLID.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.Repository.Repository
{
    public class ContasRepository
    {
        private readonly DbContextSolid db;
        public ContasRepository(DbContextSolid context)
        {
            db = context;
        }

        public List<Conta> Listar()
        {
            return db.Contas.ToList();
        }

        public Conta BuscarPorId(int id)
        {
            return db.Contas.Find(id);
        }

        public void Inserir(Conta conta)
        {
            db.Contas.Add(conta);
            Salvar();
        }

        public void Atualizar(Conta conta)
        {
            db.Contas.Attach(conta);
            Salvar();
        }

        public void Salvar()
        {
            db.SaveChanges();
        }

    }
}
