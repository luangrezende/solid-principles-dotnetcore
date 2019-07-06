using System.ComponentModel.DataAnnotations;

namespace SOLID.Models.Models
{
    public abstract class Account
    {
        [Key]
        public int ID { get; set; }

        public double Balance { get; set; }

        public abstract void Deposit(double value);
        public abstract void Serve(double value);
    }
}
