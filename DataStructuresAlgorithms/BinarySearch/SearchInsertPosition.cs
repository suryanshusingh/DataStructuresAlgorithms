using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.BinarySearch
{
    class SearchInsertPosition
    {
        //Rename this method to Main to run
        // LeetCode: https://leetcode.com/problems/search-insert-position/
        public static void NotMain(string[] args)
        {
            int[] nums = new int[4] {1,3,5,6};
            Console.WriteLine(SearchInsert(nums, 5));
        }

        //Time Complexity - O(logN)
        //Space Complexity - O(1)
        public static int SearchInsert(int[] nums, int target)
        {
            int start = 0; int end = nums.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else end = mid - 1;
            }
            return start;
        }
    }
}
