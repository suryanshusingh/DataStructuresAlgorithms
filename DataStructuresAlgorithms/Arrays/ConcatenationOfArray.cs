using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Arrays
{
    //https://leetcode.com/problems/concatenation-of-array/
    class ConcatenationOfArray
    {
        public static void NotMain(string[] args)
        {
            Console.WriteLine();
        }
        public static int[] GetConcatenation(int[] nums)
        {
            int[] arr = new int[2 * nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                arr[i] = nums[i];
                arr[i + nums.Length] = nums[i];
            }
            return arr;
        }

    }
}
