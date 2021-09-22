using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.BinarySearch
{
    class SqrtOfANumber
    {
        // Leet Code - https://leetcode.com/problems/sqrtx/
        //Rename this method to Main to run
        public static void NotMain(String[] args)
        {
            Console.WriteLine(SqrtOfANumberMethod(16));
        }

        //Time Complexity - O(logN)
        //Space Complexity - O(1)
        private static int SqrtOfANumberMethod(int x)
        {
            int start = 1;
            int end = x;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (mid <= x / mid)
                {
                    start = mid + 1;
                }
                else if (mid > x / mid)
                {
                    end = mid - 1;
                }
            }
            return end;
        }

        private static int SqrtOfANumber2(int x)
        {
            if (x == 0) return 0;
            int start = 1; int end = x;
            while (true)
            {
                int mid = start + (end - start) / 2;
                if (mid > x / mid)
                {
                    end = mid - 1;
                }
                else
                {
                    if (mid + 1 > x / (mid + 1)) return mid;
                    start = mid + 1;
                }
            }
        }
    }
}
