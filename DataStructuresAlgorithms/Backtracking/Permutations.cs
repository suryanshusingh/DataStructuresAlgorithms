using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Backtracking
{
    class Permutations
    {
        static List<List<int>> result = new List<List<int>>();
        public static void NotMain(string[] args)
        {

            Permutations p = new Permutations();
            p.Permutation(new int[] { 1, 2, 3 ,4}, 0);
            foreach(var res in result)
            {
                res.ForEach(i => Console.Write(i));
                Console.WriteLine();
            }
        }

        private void Permutation(int[] arr, int l)
        {
            if(l == arr.Length)
            {
                result.Add(new List<int>(arr));
                return;
            }

            for (int i = l; i < arr.Length; i++)
            {
                swap(arr, i, l);
                Permutation(arr, l + 1);
                swap(arr, l, i);
            }

        }

        private void swap(int[] arr, int first, int second)
        {
            int temp = arr[first];
            arr[first] = arr[second];
            arr[second] = temp;
        }
    }
}
