using SOLID.Business;

namespace SOLID.Models.Models
{
    public class CheckingAccount : Account
    {
        public override void Deposit(double value)
        {
            Balance += CheckingAccountBusiness.CalculateDeposit(value);
        }

        public override void Serve(double value)
        {
            Balance -= CheckingAccountBusiness.CalculateServe(value);
        }
    }
}
