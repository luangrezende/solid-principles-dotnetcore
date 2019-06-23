using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Database.Models
{
    public abstract class Debito
    {
        [Key]
        public int ID { get; set; }

        public int Valor { get; set; }

        public int Conta_ID { get; set; }
        [ForeignKey("Conta_ID")]
        public virtual Contas Conta { get; set; }

        public abstract int Depositar(int valor);
    }
}
