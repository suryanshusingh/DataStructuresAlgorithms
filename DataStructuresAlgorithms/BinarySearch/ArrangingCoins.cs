using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.BinarySearch
{
    class ArrangingCoins
    {
        //Rename this method to Main to run
        // LeetCode: https://leetcode.com/problems/arranging-coins/
        public static void Main(string[] args)
        {
            Console.WriteLine(ArrangeCoins(55));
        }

        //Time Complexity - O(logN)
        //Space Complexity - O(1)
        public static int ArrangeCoins(int n)
        {
            long start = 0;
            long end = n;
            while (start <= end)
            {
                long mid = start + (end - start) / 2;
                long requiredcoins = (mid * (mid + 1)) / 2;
                if (n == requiredcoins)
                {
                    return (int)mid;
                }
                else if (n > requiredcoins)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return (int)end;
        }
            
    }
}
