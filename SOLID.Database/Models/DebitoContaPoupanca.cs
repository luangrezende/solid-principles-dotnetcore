using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Database.Models
{
    public class DebitoContaPoupanca : Debito
    {
        public override int Depositar(int valor)
        {
            return Valor += valor;
        }
    }
}
