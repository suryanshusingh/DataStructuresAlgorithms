using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Sorting
{
    class SquaresOfASortedArray
    {
        //https://leetcode.com/problems/squares-of-a-sorted-array/
        public static void NotMain(string[] args)
        {
            int[] nums = new int[] { -4, -1, 0, 3, 10 };
            Console.WriteLine(SortedSquares(nums));
        }

        public static int[] SortedSquares(int[] nums)
        {
            int[] arr = new int[nums.Length];
            int start = nums.Length - 1; int j = nums.Length - 1;
            for (int i = 0; i < nums.Length && i <= j;)
            {
                if (Math.Abs(nums[i]) > Math.Abs(nums[j]))
                {
                    arr[start--] = nums[i] * nums[i];
                    i++;
                }
                else
                {
                    arr[start--] = nums[j] * nums[j];
                    j--;
                }
            }
            return arr;
        }
    }
}
