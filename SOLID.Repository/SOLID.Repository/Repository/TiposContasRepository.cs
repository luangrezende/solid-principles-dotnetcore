using Microsoft.EntityFrameworkCore;
using SOLID.Database;
using SOLID.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.Repository.Repository
{
    public class TiposContasRepository
    {
        private readonly DbContextSolid db;
        public TiposContasRepository(DbContextSolid context)
        {
            db = context;
        }

        public List<TiposTransacoes> Listar()
        {
            return db.TiposContas.ToList();
        }

        public TiposTransacoes BuscarPorId(int id)
        {
            return db.TiposContas.Find(id);
        }

    }
}
