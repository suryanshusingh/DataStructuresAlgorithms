using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Matrix
{

    class Matrix01
    {
        // https://leetcode.com/problems/01-matrix/
        public static void NotMain(string[] args)
        {
            int[][] matrix = new int[][] { new int[] { 0, 0, 0 },new int[] { 0, 1, 0 }, new int[]{ 1, 1, 1 } };
            Matrix.DisplayMatrix(matrix);
            Matrix.DisplayMatrix(UpdateMatrix(matrix));
            Console.Read();
        }

        public static int[][] UpdateMatrix(int[][] mat)
        {
            int[][] direction = new int[][] { new int[] { 0, -1 }, new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };
            int rows = mat.Length;
            int columns = mat[0].Length;
            Queue<int[]> queue = new Queue<int[]>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        queue.Enqueue(new int[] { i, j });
                    }
                    else
                    {
                        mat[i][j] = -1;
                    }
                }
            }
            while (queue.Count > 0)
            {
                int[] current = queue.Dequeue();
                for (int i = 0; i < 4; i++)
                {
                    int row = current[0] + direction[i][0];
                    int column = current[1] + direction[i][1];
                    if (row < 0 || column < 0 || row >= rows || column >= columns || mat[row][column] != -1) continue;
                    mat[row][column] = mat[current[0]][current[1]] + 1;
                    queue.Enqueue(new int[] { row, column });
                }
                Matrix.DisplayMatrix(mat);
            }
            return mat;
        }
    }

    class Matrix
    {
        public static void DisplayMatrix(int[][] matrix)
        {
            for(int i=0;i<matrix.Length;i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
