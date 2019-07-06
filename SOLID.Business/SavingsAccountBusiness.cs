namespace SOLID.Business
{
    public class SavingsAccountBusiness
    {
        public static double CalculateDeposit(double value)
        {
            return value;
        }

        public static double CalculateServe(double value)
        {
            double taxes = 0.03 * value;
            return value - taxes;
        }
    }
}
