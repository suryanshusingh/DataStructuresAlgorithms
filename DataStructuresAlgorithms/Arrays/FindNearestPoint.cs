using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Arrays
{
    class FindNearestPoint
    {
        public static void NotMain(string[] args)
        {
            int[][] points = new int[][] { new int[] { 1, 2 }, new int[] { 3, 1 }, new int[] { 2, 4 }, new int[] { 2, 3 }, new int[] { 4, 4 } };
            NearestValidPoint(3, 4, points);
            Console.Read();
        }

        public static int NearestValidPoint(int x, int y, int[][] points)
        {
            int min = int.MaxValue;
            int index = -1;
            for (int i = 0; i < points.Length; i++)
            {
                if (x == points[i][0] || y == points[i][1])
                {
                    int distance = Math.Abs(x - points[i][0]) + Math.Abs(y - points[i][1]);
                    if (min > distance)
                    {
                        min = distance;
                        index = i;
                    }
                }
            }
            return index;
        }
    }
}
