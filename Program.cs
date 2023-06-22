namespace LetUsLeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Two Sum Testing
            int[] numbers = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = twoSum.TwoSum(numbers, target);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}