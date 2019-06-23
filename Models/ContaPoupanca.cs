using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Models
{
    public class ContaPoupanca : Conta
    {
        public override int Depositar(int valor)
        {
            return Saldo += valor;
        }
    }
}
