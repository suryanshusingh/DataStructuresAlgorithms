using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Arrays
{
    // https://leetcode.com/problems/matrix-diagonal-sum/
    //Rename this method to Main to run
    class MatrixDiagonalSum
    {
        private static void NotMain(string[] args)
        {

        }

        public static int DiagonalSum(int[][] mat)
        {
            int sum = 0;
            int n = mat.Length;
            for (int i = 0; i < n; i++)
            {
                sum += mat[i][i];
                sum += mat[i][n - i - 1];
            }
            if (n % 2 == 1) sum -= mat[n / 2][n / 2];
            return sum;
        }
    }
}
