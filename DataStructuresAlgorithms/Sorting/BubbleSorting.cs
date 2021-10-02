using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Sorting
{
    class BubbleSorting
    {

        public static void NotMain(string[] args)
        {
            //int[] arr = [1, 2, 4, 3, 7, 6, 0, 8, 5];


        }
        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool swapped = false;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = arr[j];
                        swapped = true;
                    }
                }
                if (swapped == false)
                {
                    break;
                }
            }
        }

    }

    
}
