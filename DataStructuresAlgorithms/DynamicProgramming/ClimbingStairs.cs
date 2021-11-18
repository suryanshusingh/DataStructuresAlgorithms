using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.DynamicProgramming
{
    class ClimbingStairs
    {
        //Leetcode: leetcode.com/problems/climbing-stairs
        public static void NotMain(string[] args)
        {
            Console.WriteLine(ClimbStairs(5));
        }

        private static int ClimbStairs(int n)
        {
            if (n == 0 || n == 1 || n == 2) return n;
            int stepOne = 1;
            int stepTwo = 2;
            for (int i = 2; i < n; i++)
            {
                int result = stepOne + stepTwo;
                stepOne = stepTwo;
                stepTwo = result;
            }
            return stepTwo;
        }
    }
}
