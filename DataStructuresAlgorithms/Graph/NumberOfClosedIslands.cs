using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Graph
{
    class NumberOfClosedIslands
    {
        //https://leetcode.com/problems/number-of-closed-islands/
        public static void NotMain(string[] args)
        {
            int[][] grid = new int[][] { new int[] { 1, 1, 1,1,1,1,1,0 }, new int[] { 1, 0, 0,0,0,1,1,0 }, new int[] { 1, 0,1,0,1, 1,1,0 }, new int[] { 1, 0, 0, 0, 0, 1, 0, 1 },
            new int[] { 1, 1, 1, 1, 1, 1, 1, 0 } };

            int[][] grid1 = new int[][] {new int[] {0, 0, 1, 1, 0, 1, 0, 0, 1, 0 },new int[] {1, 1, 0, 1, 1, 0, 1, 1, 1, 0 },new int[] {1, 0, 1, 1, 1, 0, 0, 1, 1, 0 },
            new int[] {0, 1, 1, 0, 0, 0, 0, 1, 0, 1 },
                new int[] {0, 0, 0, 0, 0, 0, 1, 1, 1, 0 },new int[] {0, 1, 0, 1, 0, 1, 0, 1, 1, 1 },new int[] {1, 0, 1, 0, 1, 1, 0, 0, 0, 1 },
            new int[] {1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },new int[] {1, 1, 1, 0, 0, 1, 0, 1, 0, 1 },
                new int[] {1, 1, 1, 0, 1, 1, 0, 1, 1, 0 } };

            Matrix.DisplayMatrix(grid1);
            int result = ClosedIslands(grid1);
            Console.WriteLine(result);
            Console.Read();

        }

        //https://leetcode.com/problems/number-of-closed-islands/
        public static int ClosedIslands(int[][] grid)
        {
            int row = grid.Length;
            int col = grid[0].Length;
            int result = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i * j == 0 || i == row - 1 || j == col - 1)
                    {
                        //grid[i][j] =  1;
                        FillClosedIsland(grid, i, j, row, col);
                    }
                }
            }
            Matrix.DisplayMatrix(grid);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        FillClosedIsland(grid, i, j, row, col);
                        result++;
                    }
                }
            }
            return result;
        }

        public static void FillClosedIsland(int[][] grid, int i, int j, int row, int col)
        {
            if (i < 0 || j < 0 || i >= row || j >= col || grid[i][j] == 1) return;
            grid[i][j] = 1;
            FillClosedIsland(grid, i + 1, j, row, col);
            FillClosedIsland(grid, i - 1, j, row, col);
            FillClosedIsland(grid, i, j + 1, row, col);
            FillClosedIsland(grid, i, j - 1, row, col);
        }

        
    }
}
