using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.BinarySearch
{
    class SimpleBinarySearch
    {
        //Rename this method to Main to run
        public static void NotMain(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int target = 8;
            int index = BinarySearch(arr, target);
            Console.WriteLine(index);
            Console.Read();
        }

        private static int BinarySearch(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    start = mid + 1;
                }
                else if (arr[mid] > target)
                {
                    end = mid - 1;
                }
            }
            return -1;
        }
    }
}
