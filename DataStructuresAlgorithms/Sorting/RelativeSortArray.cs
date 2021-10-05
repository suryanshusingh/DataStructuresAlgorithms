using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Sorting
{
    class RelativeSortArray
    {
        //https://leetcode.com/problems/relative-sort-array/
        public static void NotMain(string[] args)
        {

        }
        public int[] RelativeSortArray1(int[] arr1, int[] arr2)
        {
            int[] first = new int[1001];
            int[] result = new int[arr1.Length];
            foreach (var num in arr1)
            {
                first[num] += 1;
            }
            int i = 0;
            foreach (var num in arr2)
            {
                while (first[num] != 0)
                {
                    result[i++] = num;
                    first[num] -= 1;
                }
            }
            for (int j = 0; j < first.Length;)
            {
                if (first[j] != 0)
                {
                    result[i++] = j;
                    first[j] -= 1;
                }
                else
                {
                    j++;
                }
            }
            return result;
        }
    }
}
