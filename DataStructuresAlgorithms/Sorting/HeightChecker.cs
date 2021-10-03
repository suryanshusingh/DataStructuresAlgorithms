using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Sorting
{
    class HeightChecker
    {
        //https://leetcode.com/problems/height-checker/
        public static void NotMain(string[] args)
        {

        }
        public int HeightCheckerSolution(int[] heights)
        {
            int[] arr = new int[101];
            foreach (var height in heights)
            {
                arr[height] += 1;
            }
            int ptr = 0; int res = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                while (arr[ptr] == 0)
                {
                    ptr++;
                }

                if (heights[i] != ptr)
                {
                    res++;
                }

                arr[ptr]--;
            }
            return res;
        }
    }
}
