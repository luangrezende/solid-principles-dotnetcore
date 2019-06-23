using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Database.Models
{
    public class ContaCorrente : Contas
    {
        public override int Depositar(int valor)
        {
            return Saldo += valor + 200;
        }
    }
}
