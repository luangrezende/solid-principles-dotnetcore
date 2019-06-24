using SOLID.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Database.Models
{
    public class ContaPoupanca : Conta
    {
        public override void Depositar(double valor)
        {
            Saldo += ContasBusiness.CalcularDepositoPoupanca(valor);
        }

        public override void Sacar(double valor)
        {
            Saldo -= ContasBusiness.CalcularSaquePoupanca(valor);
        }
    }
}
