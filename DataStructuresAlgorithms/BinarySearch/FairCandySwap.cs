using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.BinarySearch
{
    class FairCandySwap
    {
        //https://leetcode.com/problems/fair-candy-swap/
        //Rename this method to Main to run
        public static void NotMain(string[] args)
        {
            

            Console.Read();
        }

        // This can be solved in two ways.
        public static int[] FairCandySwapMethod(int[] aliceSizes, int[] bobSizes)
        {
            //SumA = 2;
            //Sumb = 4;
            //suma - x + y = sumb +x -y
            // x - y = (suma -sumb)/2
            int suma = 0; int sumb = 0;
            for (int i = 0; i < aliceSizes.Length; i++)
            {
                suma += aliceSizes[i];
            }
            for (int i = 0; i < bobSizes.Length; i++)
            {
                sumb += bobSizes[i];
            }
            int diff = (suma - sumb) / 2;

            // This is of time complexity O(n*n) and space of O(1)
            //for(int i =0; i<aliceSizes.Length; i++)
            //{
            //    for(int j =0; j<bobSizes.Length; j++)
            //    {
            //        if(diff == aliceSizes[i]-bobSizes[j]) return new int[] {aliceSizes[i],bobSizes[j]};
            //    }
            //}

            // This is of time complexity O(n) and space of O(1)
            HashSet<int> result = new HashSet<int>();
            for (int i = 0; i < aliceSizes.Length; i++)
            {
                result.Add(aliceSizes[i]);
            }
            for (int j = 0; j < bobSizes.Length; j++)
            {
                if (result.Contains(diff + bobSizes[j])) return new int[] { diff + bobSizes[j], bobSizes[j] };
            }
            return null;
        }
    }
}
