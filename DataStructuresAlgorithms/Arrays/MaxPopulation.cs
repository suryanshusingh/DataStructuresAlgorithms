using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Arrays
{
    class MaxPopulation
    {
        // https://leetcode.com/problems/maximum-population-year/submissions/
        //Rename this method to Main to run
        private static void NotMain(string[] args)
        {
            int[][] logs = new int[][] { new int[]{ 1982, 1998 }, new int[] { 2013, 2042 }, new int[] { 2010, 2035 },
                new int[]{ 2022, 2050 }, new int[]{ 2047, 2048 } };
            MaximumPopulation(logs);
        }

        public static int MaximumPopulation(int[][] logs)
        {
            int[] a = new int[101];
            for (int i = 0; i < logs.Length; i++)
            {
                a[logs[i][0] - 1950]++;
                a[logs[i][1] - 1950]--;
            }

            int sum = 0;
            for (int i = 1; i < a.Length; i++)
            {
                a[i] += a[i - 1];
            }
            int max = 0;
            int maxIndex = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    maxIndex = i;
                }
            }
            return maxIndex + 1950;
        }
    }
}
