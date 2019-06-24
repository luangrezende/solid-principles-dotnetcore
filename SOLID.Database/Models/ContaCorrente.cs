using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Database.Models
{
    public class ContaCorrente : Conta
    {
        public override void Depositar(int valor)
        {
            Saldo += valor;
        }

        public override void Sacar(int valor)
        {
            double taxas = 0.05 * valor;
            Saldo -= valor - taxas;
        }
    }
}
