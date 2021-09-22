using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.BinarySearch
{
    class ValidPerfectSquare
    {
        //https://leetcode.com/problems/valid-perfect-square/
        //Rename this method to Main to run
        public static void NotMain(string[] args)
        {
            Console.WriteLine(IsIsPerfectSquare(2147483647));
        }

        //Time Complexity - O(N)
        //Space Complexity - O(1)
        public static bool IsIsPerfectSquare(int num)
        {
            int start = 1; int track = 3;
            while (num > 0)
            {
                num = num - start;
                start = start + 2;
            }
            return num == 0;
        }

        //Time Complexity - O(logN)
        //Space Complexity - O(1)
        public static bool IsPerfectSquare(int num)
        {
            int start = 1; int end = num;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (mid < num / mid)
                {
                    start = mid + 1;
                }
                else if (num % mid == 0 && mid == num / mid) return true;
                else
                    end = mid - 1;
            }
            return false;
        }
    }
}
