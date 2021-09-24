using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.BinarySearch
{
    class IntersectionOfTwoArrays
    {
        //https://leetcode.com/problems/intersection-of-two-arrays/
        //Rename this method to Main to run
        public static void NotMain(string[] args)
        {
            int[] nums1 = new int[]{1, 2, 2, 1}; int[] nums2 = new int[] { 2, 2};
            int[] result = Intersection(nums1, nums2);
            Console.WriteLine(result[0]);
            Console.Read();
        }

        // This can be solved in 3 ways:
        //1. linear search in both the arrays and compare. O(n2) time complextiy and O(1) space.
        //2. We can use hashset. O(n) time complexity and O(n) space.
        //3. Sort one array(the smaller size) and loop through another. O(nlogn) time complexity and O(1).
        //4. Sort both the arrays and use pointer increment technique. O(nlogn) time complexity and O(1).

        //This is method 3
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (Found(nums1, nums2[i]))
                {
                    hash.Add(nums2[i]);
                }
            }
            int[] result = new int[hash.Count];
            hash.CopyTo(result);
            return result;
        }

        private static bool Found(int[] nums, int target)
        {
            int start = 0; int end = nums.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] < target)
                {
                    start = mid + 1;

                }
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else return true;
            }
            return false;
        }
    }
}
