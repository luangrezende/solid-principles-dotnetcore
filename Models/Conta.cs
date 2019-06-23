using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Models
{
    public abstract class Conta
    {
        public int Saldo { get; set; }

        public abstract int Depositar(int valor);
    }
}
