using System.ComponentModel.DataAnnotations;

namespace SOLID.Database.Models
{
    public abstract class Conta
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }

        public abstract void Depositar(double valor);
        public abstract void Sacar(double valor);
    }
}
