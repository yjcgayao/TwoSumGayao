using System;

namespace TwoSumSolution
{
    public class Solution
    {
        // Method to find indices of two numbers that add up to the target
        public int[] TwoSum(int[] nums, int target)
        {
            // Iterate through the array
            for (int i = 0; i < nums.Length; i++)
            {
                // Check all pairs with the current number
                for (int j = i + 1; j < nums.Length; j++)
                {
                    // If the sum equals the target, return the indices
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            // No valid solution found, throw an exception
            throw new ArgumentException("No valid solution exists.");
        }

        public static void Main(string[] args)
        {
            // Prompt user for input
            Console.WriteLine("Enter the array of integers (comma-separated):");
            string input = Console.ReadLine();
            int[] nums = Array.ConvertAll(input.Split(','), int.Parse);

            Console.WriteLine("Enter the target sum:");
            int target = int.Parse(Console.ReadLine());

            try
            {
                // Find the indices of the two numbers
                int[] result = new Solution().TwoSum(nums, target);
                Console.WriteLine($"Indices of the two numbers: [{result[0]}, {result[1]}]");
            }
            catch (ArgumentException ex)
            {
                // Handle the case where no valid solution exists
                Console.WriteLine(ex.Message);
            }
        }
    }
}
