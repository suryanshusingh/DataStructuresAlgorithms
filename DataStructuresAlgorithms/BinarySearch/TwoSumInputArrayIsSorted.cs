using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.BinarySearch
{
    class TwoSumInputArrayIsSorted
    {
        //https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
        //Rename this method to Main to run
        public static void NotMain(string[] args)
        {
            var numbers = new int[4] { 2, 7, 11, 15 };
            var a = TwoSum(numbers, 9);
            Console.WriteLine($"{a[0]}, {a[1]}");
        }

        //Time Complexity - O(N)
        //Space Complexity - O(1)
        public static int[] TwoSum(int[] numbers, int target)
        {
            int start = 0;
            int end = numbers.Length - 1;
            while (numbers[start] + numbers[end] != target)
            {
                if (numbers[start] + numbers[end] > target)
                {
                    end--;
                }
                else start++;
            }
            return new int[] { start + 1, end + 1 };
        }
    }
}
