namespace LetUsLeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Two Sum Testing
            //int[] numbers = { 2, 7, 11, 15 };
            //int target = 9;
            //int[] result = twoSum.TwoSum(numbers, target);

            //Console.WriteLine(string.Join(" ", result));

            //Best Time to Buy and Sell Stock

            int[] prices = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(bestTimeToBuyAndSellStock.MaxProfit(prices));
        }
    }
}