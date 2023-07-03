namespace LetUsLeetCode
{
    public static class BestTimeToBuyAndSellStock
    {
        public static int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            foreach (int price in prices)
            {
                minPrice = Math.Min(price, minPrice);

                maxProfit = Math.Max(maxProfit, price - minPrice);
            }

            return maxProfit;
        }
    }
}
