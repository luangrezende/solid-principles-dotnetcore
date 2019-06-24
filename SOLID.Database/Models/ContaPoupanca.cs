using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Database.Models
{
    public class ContaPoupanca : Conta
    {
        public override void Depositar(int valor)
        {
            Saldo += valor;
        }

        public override void Sacar(int valor)
        {
            double taxas = 0.03 * valor;
            Saldo -= valor - taxas;
        }
    }
}
