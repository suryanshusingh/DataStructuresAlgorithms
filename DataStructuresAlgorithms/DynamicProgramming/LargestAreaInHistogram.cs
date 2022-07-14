using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.DynamicProgramming
{
    public class LargestAreaInHistogram
    {
        public static void NotMain(string[] args)
        {
            Console.WriteLine(LargestRectangleArea(new int[] { 2, 1, 5, 6, 2, 3 }));

        }

        public static int LargestRectangleArea(int[] height)
        {
            if (height == null || height.Length == 0)
            {
                return 0;
            }
            int[] lessFromLeft = new int[height.Length]; // idx of the first bar the left that is lower than current
            int[] lessFromRight = new int[height.Length]; // idx of the first bar the right that is lower than current
            lessFromRight[height.Length - 1] = height.Length;
            lessFromLeft[0] = -1;

            for (int i = 1; i < height.Length; i++)
            {
                int p = i - 1;

                while (p >= 0 && height[p] >= height[i])
                {
                    p = lessFromLeft[p];
                }
                lessFromLeft[i] = p;
            }

            for (int i = height.Length - 2; i >= 0; i--)
            {
                int p = i + 1;

                while (p < height.Length && height[p] >= height[i])
                {
                    p = lessFromRight[p];
                }
                lessFromRight[i] = p;
            }

            int maxArea = 0;
            for (int i = 0; i < height.Length; i++)
            {
                maxArea = Math.Max(maxArea, height[i] * (lessFromRight[i] - lessFromLeft[i] - 1));
            }

            return maxArea;
        }
    }
}
