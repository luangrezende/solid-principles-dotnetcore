using SOLID.Business;
using System.ComponentModel.DataAnnotations;

namespace SOLID.Models.Models
{
    public class Extract
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Account number")]
        public int Account_ID { get; set; }

        [Display(Name = "Value")]
        public double Value { get; set; }

        [Display(Name = "Extract number")]
        public int Number { get; set; }

        public void GenerateNumber()
        {
            Number = ExtractBusiness.RandomNumber();
        }
    }
}
