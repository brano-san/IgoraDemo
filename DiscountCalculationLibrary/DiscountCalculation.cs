namespace DiscountCalculationLibrary
{
    public class DiscountCalculation
    {
        public static int calculateDiscount(int sum)
        {
            if (sum < 50_000)
            {
                return 0;
            }
            else if (sum >= 50_000 && sum < 100_000)
            {
                return 1;
            }
            else if (sum >= 100_000 && sum < 300_000)
            {
                return 3;
            }
            else
            {
                return 5;
            }
        }
    }
}
