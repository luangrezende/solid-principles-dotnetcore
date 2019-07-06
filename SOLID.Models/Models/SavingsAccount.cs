using SOLID.Business;

namespace SOLID.Models.Models
{
    public class SavingsAccount : Account
    {
        public override void Deposit(double value)
        {
            Balance += SavingsAccountBusiness.CalculateDeposit(value);
        }

        public override void Serve(double value)
        {
            Balance -= SavingsAccountBusiness.CalculateServe(value);
        }
    }
}
