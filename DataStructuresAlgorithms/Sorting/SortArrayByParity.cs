using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Sorting
{
    class SortArrayByParity
    {
        //https://leetcode.com/problems/sort-array-by-parity/
        public static void NotMain(string[] args)
        {

        }

        public int[] SortArrayByParity1(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            while (start < end)
            {
                if (nums[start] % 2 == 0)
                {
                    start++;
                }
                else
                {
                    if (nums[end] % 2 == 0)
                    {
                        swap(nums, start, end);
                        start++; end--;
                    }
                    else
                    {
                        end--;
                    }
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
