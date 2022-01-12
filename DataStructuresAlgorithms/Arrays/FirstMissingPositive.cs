using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Arrays
{
    class FirstMissingPositive
    {
        public static void NotMain(string[] args)
        {
            int[] nums = new int[] { 9, 3, 4, -1, 1, 2, 6, 9 };
            int a = FirstMissingPositiveMethod(nums);
            Console.WriteLine();
        }

        public static int FirstMissingPositiveMethod(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                while (nums[i] > 0 && nums[i] <= nums.Length && nums[nums[i] - 1] != nums[i])
                {
                    Swap(nums, i, nums[i] - 1);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1) return i + 1;
            }
            return nums.Length + 1;
        }

        private static void Swap(int[] nums, int i, int j)
        {
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }
    }
}
