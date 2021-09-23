using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.BinarySearch
{
    class PeakIndexInAMountainArray
    {
        //https://leetcode.com/problems/peak-index-in-a-mountain-array/
        //Rename this method to Main to run
        public static void NotMain(string[] args)
        {
            int[] arr = new int[10] { 24, 69, 100, 99, 79, 78, 67, 36, 26, 19 };
            Console.WriteLine(PeakIndexInMountainArray(arr));
            Console.WriteLine(PeakIndexInMountainArray2(arr));

            Console.Read();
        }

        //Time Complexity - O(logN)
        //Space Complexity - O(1)
        public static int PeakIndexInMountainArray(int[] arr)
        {
            int start = 0; int end = arr.Length - 1;
            while(start<=end)
            {
                int mid = start + (end - start) / 2;
                if(arr[mid]>arr[mid+1])
                {
                    if (arr[mid] > arr[mid - 1]) return mid;
                    end = mid - 1;
                }
                else
                {
                    if (arr[mid] > arr[mid + 1]) return mid;
                    start = mid + 1;
                }
            }
            return -1;
        }

        //Time Complexity - O(logN)
        //Space Complexity - O(1)
        public static int PeakIndexInMountainArray2(int[] arr)
        {
            int start = 0; int end = arr.Length - 1;
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] < arr[mid + 1])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }
            }
            return end;
        }
    }
}
