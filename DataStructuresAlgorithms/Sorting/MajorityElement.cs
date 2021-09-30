using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.Sorting
{
    class MajorityElement
    {
        // Important
        //https://leetcode.com/problems/majority-element/
        public static void NotMain(string[] args)
        {

        }

        public int FindMajorityElement(int[] nums)
        {
            int count = 0;
            int answer = 0;
            foreach (var num in nums)
            {
                if (count == 0)
                {
                    answer = num;
                }
                if (answer == num) count++;
                else count--;
            }
            return answer;
        }
    }
}
