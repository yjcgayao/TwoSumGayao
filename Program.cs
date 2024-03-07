using System;
using System.Collections.Generic;

namespace TwoSumSolution
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            // Create a dictionary to store the value-to-index mapping
            Dictionary<int, int> numToIndex = new Dictionary<int, int>();

            // Iterate through the array
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                // If the complement exists in the dictionary, return the indices
                if (numToIndex.TryGetValue(complement, out int index))
                {
                    return new int[] { index, i };
                }

                // Otherwise, add the current number to the dictionary
                numToIndex[nums[i]] = i;
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
                //Console.WriteLine($"Explanation: Because nums[{result[0]}] + nums[{result[1]}] == {target}, we return [{result[0]}, {result[1]}].");
            }
            catch (ArgumentException ex)
            {
                // Handle the case where no valid solution exists
                Console.WriteLine(ex.Message);
            }
        }
    }
}
