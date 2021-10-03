using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Sorting
{
    class SortArrayByParity2
    {
        //https://leetcode.com/problems/sort-array-by-parity-ii/
        public static void NotMain(string[] args)
        {

        }

        public int[] SortArrayByParity22(int[] nums)
        {
            int i = 0; int j = 1;
            while (i < nums.Length && j < nums.Length)
            {
                while (i < nums.Length && nums[i] % 2 == 0)
                {
                    i = i + 2;
                }
                while (j < nums.Length && nums[j] % 2 == 1)
                {
                    j = j + 2;
                }
                if (i < nums.Length && j < nums.Length)
                {
                    swap(nums, i, j);
                }
            }
            return nums;

        }

        public void swap(int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
    }
}
