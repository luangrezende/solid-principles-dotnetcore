namespace SOLID.Business
{
    public class CheckingAccountBusiness
    {
        public static double CalculateDeposit(double value)
        {
            return value;
        }

        public static double CalculateServe(double value)
        {
            double taxes = 0.05 * value;
            return value - taxes;
        }
    }
}
