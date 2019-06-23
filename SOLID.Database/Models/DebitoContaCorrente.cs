using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Database.Models
{
    public class DebitoContaCorrente : Debito
    {
        public override int Depositar(int valor)
        {
            return Valor += valor + 200;
        }
    }
}
