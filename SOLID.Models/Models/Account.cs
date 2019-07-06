using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOLID.Models.Models
{
    public abstract class Account
    {
        [Key]
        public int ID { get; set; }

        public double Balance { get; set; }

        public int User_ID { get; set; }
        [ForeignKey("User_ID")]
        public virtual User User { get; set; }

        public abstract void Deposit(double value);
        public abstract void Serve(double value);
    }
}
