using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Sorting
{
    class MergeSortedArray
    {
        //https://leetcode.com/problems/merge-sorted-array/
        public static void NotMain()
        {

        }


        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int length = m + n - 1;
            while (i >= 0 && j >= 0)
            {
                if (nums1[i] >= nums2[j])
                {
                    nums1[length--] = nums1[i--];
                }
                else
                {
                    nums1[length--] = nums2[j--];
                }
            }
            while (j >= 0)
            {
                nums1[length--] = nums2[j--];
            }
        }
    }
}
