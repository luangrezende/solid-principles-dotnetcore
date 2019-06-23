using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Database.Models
{
    public class Contas
    {
        public int ID { get; set; }

        public int Saldo { get; set; }

        public virtual List<Debito> Debitos { get; set; }
    }
}
