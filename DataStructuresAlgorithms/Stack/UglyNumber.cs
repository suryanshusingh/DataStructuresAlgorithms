using System;
using System.Collections.Generic;
using System.Dynamic;

namespace DataStructuresAlgorithms.Stack
{
    internal class UglyNumber
    {
        public static void NotMain(string[] args)
        {
            int answer = NthUglyNumber(10);   
        }
        public static int NthUglyNumber(int n)
        {
            if (n == 1) return 1;
            int p2 = 1;
            int p3 = 1;
            int p5 = 1;
            Stack<int> s = new Stack<int>();
            s.Push(1);
            int min = 0;
            while(s.Count <= n)
            {
                int num2 = 2 * p2;
                int num3 = 3 * p3;
                int num5 = 5 * p5;
                min = Math.Min(num2, Math.Min(num3, num5));

                if (s.Peek() != min) s.Push(min);
                if (min == num2) p2++;
                if (min == num3) p3++;
                if (min == num5) p5++;

            }
            return s.Peek();
        }
    }
}
