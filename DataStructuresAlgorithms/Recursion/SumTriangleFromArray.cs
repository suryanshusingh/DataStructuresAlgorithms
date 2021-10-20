using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Recursion
{
    class SumTriangleFromArray
    {
        public static void NotMain(string[] args)
        {
            int[] A = { 1, 2, 3, 4, 5 };
            SumTriangle(A);

        }

        private static void SumTriangle(int[] arr)
        {
            if(arr.Length < 2)
            {
                Console.WriteLine(arr[0]);
                return;
            }

            //print array
            
            int[] arr1 = new int[arr.Length - 1];
            for (int i = 0; i <arr.Length - 1; i++)
            {
                arr1[i] = arr[i] + arr[i + 1];
            }
            SumTriangle(arr1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
