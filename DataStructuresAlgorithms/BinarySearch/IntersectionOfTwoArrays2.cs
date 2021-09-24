using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.BinarySearch
{
    class IntersectionOfTwoArrays2
    {
        //https://leetcode.com/problems/intersection-of-two-arrays-ii/
        //Rename this method to Main to run
        public static void NotMain(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 2, 1};
            int[] nums2 = new int[] { 2, 2 };
            Intersection(nums1, nums2);
        }

        //1. Can be solved using Dictionary with TimeComplexity of O(N) and Space Complexity of O(N)
        //2. Sort both arrays and use two pointer method. TimeComplexity will be O(nlogn) and space complexity of O(1)
        private static int[] Intersection(int[] nums1, int[] nums2)
        {
            var dict = new Dictionary<int, int>();
            var result = new List<int>();
            foreach (var num in nums1)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num] = dict[num] + 1;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }
            foreach (var num in nums2)
            {
                if (dict.ContainsKey(num))
                {
                    result.Add(num);
                    if (dict[num] == 1)
                    { 
                        dict.Remove(num); 
                    }
                    else
                    {
                        dict[num] = dict[num] - 1;
                    }
                }
            }
            return result.ToArray();
        }

        public static int[] Intersect2(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            var result = new List<int>();
            int i = 0; int j = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] == nums2[j])
                {
                    result.Add(nums1[i]);
                    i++; j++;
                }
                else if (nums1[i] > nums2[j])
                {
                    j++;
                }
                else
                {
                    i++;
                }
            }

            return result.ToArray();
        }
    }
}
