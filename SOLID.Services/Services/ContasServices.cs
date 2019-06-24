using SOLID.Database;
using SOLID.Database.Models;
using SOLID.Repository.Repository;
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

        public Conta Depositar(int idConta, double valor)
        {
            Conta conta = contasRepository.BuscarPorId(idConta);
            conta.Depositar(valor);
            contasRepository.Atualizar(conta);
            return conta;
        }

        public Conta Sacar(int idConta, double valor)
        {
            Conta conta = contasRepository.BuscarPorId(idConta);
            conta.Sacar(valor);
            contasRepository.Atualizar(conta);
            return conta;
        }

        public List<Conta> ListarContas()
        {
            return contasRepository.Listar();
        }
    }
}
