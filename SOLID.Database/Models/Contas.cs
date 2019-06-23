using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Database.Models
{
    public abstract class Contas
    {
        [Key]
        public int ID { get; set; }

        public int Saldo { get; set; }

        public abstract int Depositar(int valor);
    }
}
