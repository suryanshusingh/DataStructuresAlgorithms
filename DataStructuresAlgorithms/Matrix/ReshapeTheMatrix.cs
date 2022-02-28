using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Matrix
{
    class ReshapeTheMatrix
    {
        public static void NotMain(string[] args)
        {
            int[][] matrix = new int[][] { new int[] { 0, 0, 0 }, new int[] { 1, 1, 1 }, new int[] { 1, 1, 1 }, new int[] {2,2,2 } };
            var result = MatrixReshape(matrix, 3, 4);
            Console.WriteLine();
        }

        public static int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int row = mat.Length;
            int col = mat[0].Length;
            if (row * col != r * c) return mat;
            int[][] result = new int[r][];
            for (int i = 0; i < r; i++)
            {
                result[i] = new int[c];
            }

            int a = 0;int b = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    result[a][b] = mat[i][j];
                    b++;
                    if(b>=c)
                    {
                        b = 0;
                        a++;
                    }
                }
            }
            return result;
        }
    }
}
