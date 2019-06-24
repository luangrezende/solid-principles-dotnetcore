using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Business
{
    public class ContasBusiness
    {
        public static double CalcularDepositoCorrente(double valor)
        {
            return valor;
        }

        public static double CalcularSaqueCorrente(double valor)
        {
            double taxas = 0.05 * valor;
            return valor - taxas;
        }

        public static double CalcularDepositoPoupanca(double valor)
        {
            return valor;
        }

        public static double CalcularSaquePoupanca(double valor)
        {
            double taxas = 0.03 * valor;
            return valor - taxas;
        }
    }
}
