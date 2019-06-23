using SOLID.Database;
using SOLID.Database.Models;
using SOLID.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Repository.Services
{
    public class TiposContasServices
    {
        public Debito VerificarTipoTransacao(int tipoConta)
        {
            return VerificarTipoConta(tipoConta);
        }

        private Debito VerificarTipoConta(int tipo)
        {
            if (tipo == 1)
            {
                return new DebitoContaPoupanca();
            }
            return new DebitoContaCorrente();
        }
    }
}
