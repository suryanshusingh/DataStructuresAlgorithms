using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Arrays
{
    // https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/
    //Rename this method to Main to run
    class NumbersSmallerThanTheCurrentNumber
    {
        public static void NotMain(string[] args)
        {
            int[] nums = { 8, 1, 2, 2, 3 };
            var result = SmallerNumbersThanCurrent(nums);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        //This solution works when we know the range of input number - here it is 101.
        //O(n) time and O(n) space
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] count = new int[101];
            for (int i = 0; i < nums.Length; i++)
            {
                count[nums[i]]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) nums[i] = 0;
                else
                {
                    nums[i] = count[nums[i] - 1];
                }
            }
            return nums;
        }

        //This solution works even for input number without any range.
        public static int[] SmallerNumbersThanCurrent2(int[] nums)
        {
            int[] copy = (int[])nums.Clone();
            Array.Sort(copy);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i =0; i<copy.Length;i++)
            {
                if (!dict.ContainsKey(copy[i]))
                {
                    dict.Add(copy[i], i);
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                copy[i] = dict[nums[i]];
            }
            return copy;
        }
    }
}
