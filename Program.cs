namespace LetUsLeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Two Sum Testing
            //int[] numbers = { 2, 7, 11, 15 };
            //int target = 9;
            //int[] result = TwoSum.Sum(numbers, target);

            //Console.WriteLine(string.Join(" ", result));

            //Best Time to Buy and Sell Stock
            //int[] prices = { 7, 1, 5, 3, 6, 4 };
            //Console.WriteLine(BestTimeToBuyAndSellStock.MaxProfit(prices));

            //Valid Parentheses
            //string input = "()[]{}";
            //Console.WriteLine(ValidParentheses.IsValid(input));

            //Binary Search
            int[] nums = { -1, 0, 3, 5, 9, 12 };
            int target = 9;
            Console.WriteLine(BinarySearch.Search(nums, target));
        }
    }
}
