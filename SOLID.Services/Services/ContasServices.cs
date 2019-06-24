using SOLID.Database;
using SOLID.Database.Models;
using SOLID.Repository.Repository;
using SOLID.Services.Models;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Services.Services
{
    public class ContasServices
    {
        public readonly ContasRepository contasRepository;
        public ContasServices(DbContextSolid context)
        {
            contasRepository = new ContasRepository(context);
        }

        public ContaModel Depositar(int idConta, double valor)
        {
            Conta conta = contasRepository.BuscarPorId(idConta);
            conta.Depositar(valor);
            contasRepository.Atualizar(conta);
            return MontarObjetoConta(conta);
        }

        public ContaModel Sacar(int idConta, double valor)
        {
            Conta conta = contasRepository.BuscarPorId(idConta);
            conta.Sacar(valor);
            contasRepository.Atualizar(conta);
            return MontarObjetoConta(conta);
        }

        public List<Conta> ListarContas()
        {
            return contasRepository.Listar();
        }

        private ContaModel MontarObjetoConta(Conta conta)
        {
            ContaModel contaModel = new ContaModel
            {
                Nome = conta.Nome,
                Saldo = conta.Saldo
            };
            return contaModel;
        }
    }
}
