using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.BinarySearch
{
    class CheckIfNAndItsDoubleExist
    {
        //https://leetcode.com/problems/check-if-n-and-its-double-exist/
        //Rename this method to Main to run
        public static void NotMain(string[] args)
        {
            int[] arr = new int[] { 10, 2, 7, 3 };
            Console.WriteLine(CheckIfExist(arr));
        }

        //Can be done in two ways
        //This hashset way with timecomplexity of O(n) but also space of O(n).
        // Or this can be done with timecomplexity of O(nlogn) using sorting and binary search
        public static bool CheckIfExist(int[] arr)
        {
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (hash.Contains(2 * arr[i]) || (hash.Contains(arr[i] / 2) && arr[i] % 2 == 0)) return true;
                hash.Add(arr[i]);
            }
            return false;
        }


        public bool CheckIfExist2(int[] arr)
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (Found(arr, arr[i] * 2, i) || (arr[i] % 2 == 0 && Found(arr, arr[i] / 2, i))) return true;
            }
            return false;
        }

        // index is here, so that if element is found at index, do not return. For case when there is one zero in array and two zeroes.
        private static bool Found(int[] nums, int target, int index)
        {
            int start = 0; int end = nums.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (nums[mid] == target && mid != index) return true;
                else if (nums[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }

            }
            return false;
        }
    }
}
