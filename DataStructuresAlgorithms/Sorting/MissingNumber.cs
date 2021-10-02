using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Sorting
{
    class MissingNumber
    {
        //https://leetcode.com/problems/missing-number/
        public static void NotMain(string[] args)
        {

        }

        // 1. Cyclic Sort and then search the missing number  - O(n) complexity O(1) space
        // 2. Use gaussian sum formula - n*(n+1)/2 - sum = result
        // 3. XOR solution
        public int MissingNumber1(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                int correctIndex = nums[i];
                if (nums[i] < nums.Length && nums[i] != nums[correctIndex])
                {
                    Swap(nums, i, correctIndex);
                }
                else i++;
            }

            for (int j = 0; j < nums.Length; j++)
            {
                if (j != nums[j]) return j;
            }
            return nums.Length;
        }

        public void Swap(int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
    }
}
