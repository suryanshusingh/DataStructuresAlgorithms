using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Backtracking
{
    class Combinations
    {
        public static void NotMain(string[] args)
        {
            Combine(4, 2);
        }

        public static IList<IList<int>> Combine(int n,int k)
        {
            IList<IList<int>> result = new List<IList<int>>();
            CombineHelper(n, k, result, new List<int>(), 1);
            return result;
        }

        private static void CombineHelper(int n, int k, IList<IList<int>> result, IList<int> comb, int start)
        {
            if(k==0)
            {
                result.Add(new List<int>(comb));
                return;
            }
            for (int i = start; i <= n; i++)
            {
                comb.Add(i);
                CombineHelper(n, k - 1, result, comb, i+1);
                comb.Remove(i);
            }
        }
    }
}
