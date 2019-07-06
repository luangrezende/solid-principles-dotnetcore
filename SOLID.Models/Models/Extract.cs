using SOLID.Business;
using System.ComponentModel.DataAnnotations;

namespace SOLID.Models.Models
{
    public class Extract
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Número da conta")]
        public int Account_ID { get; set; }

        [Display(Name = "Valor")]
        public double Value { get; set; }

        [Display(Name = "Número do extrato")]
        public int Number { get; set; }

        public void GenerateNumber()
        {
            Number = ExtractBusiness.RandomNumber();
        }
    }
}
