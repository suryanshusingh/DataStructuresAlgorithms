using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Graph
{
    class Matrix
    {
        public static void DisplayMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
