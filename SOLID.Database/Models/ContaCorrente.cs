using SOLID.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Database.Models
{
    public class ContaCorrente : Conta
    {
        public override void Depositar(double valor)
        {
            Saldo += ContasBusiness.CalcularDepositoCorrente(valor);
        }

        public override void Sacar(double valor)
        {
            Saldo -= ContasBusiness.CalcularSaqueCorrente(valor);
        }
    }
}
