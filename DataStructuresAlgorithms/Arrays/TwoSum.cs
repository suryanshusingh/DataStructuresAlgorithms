using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Arrays
{
    class TwoSum
    {
        //https://leetcode.com/problems/two-sum/
        public static void NotMain(string[] args)
        {

        }


        public int[] TwoSumFunc(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();


            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    return new int[] { dict[target - nums[i]], i };
                }

                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
