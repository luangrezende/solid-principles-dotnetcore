using System;

namespace SOLID.Business
{
    public class ExtractBusiness
    {
        public static int RandomNumber()
        {
            Random random = new Random();
            return random.Next(100000, 999999);
        }
    }
}
