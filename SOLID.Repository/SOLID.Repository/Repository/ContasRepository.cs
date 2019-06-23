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

        public List<Contas> Listar()
        {
            return db.Contas.ToList();
        }

        public Contas BuscarPorId(int id)
        {
            return db.Contas.Find(id);
        }

    }
}
