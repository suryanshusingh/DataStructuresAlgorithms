using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.DynamicProgramming
{
    class CountConstruct
    {
        public static void NotMain(string[] args)
        {
            Console.WriteLine(CountConstructDP("purple", new List<string> { "purp", "p", "ur", "le", "purpl" })); //2
            Console.WriteLine(CountConstructDP("abcdef", new List<string> { "ab", "abc", "cd", "def", "abcd" })); //1
            Console.WriteLine(CountConstructDP("skateboard", new List<string> { "bo", "rd", "ate", "t", "ska", "sk", "boar" })); // 0
            Console.WriteLine(CountConstructDP("enterapotentpot", new List<string> { "a", "p", "ent", "enter", "ot", "o", "t" })); //4
            Console.WriteLine(CountConstructDP("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new List<string> { "e", "ee", "eee", "eeee" }));//0
            
            Console.WriteLine();

            Console.WriteLine(CountConstructRecursion("purple", new List<string> { "purp", "p", "ur", "le", "purpl" })); //2
            Console.WriteLine(CountConstructRecursion("abcdef", new List<string> { "ab", "abc", "cd", "def", "abcd" })); //1
            Console.WriteLine(CountConstructRecursion("skateboard", new List<string> { "bo", "rd", "ate", "t", "ska", "sk", "boar" })); // 0
            Console.WriteLine(CountConstructRecursion("enterapotentpot", new List<string> { "a", "p", "ent", "enter", "ot", "o", "t" })); //4
            Console.WriteLine(CountConstructRecursion("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new List<string> { "e", "ee", "eee", "eeee" }));//0
        }

        public static int CountConstructDP(string target, List<string> wordBank)
        {
            var cache = new Dictionary<string, int>();
            return DPHelper(target, wordBank, cache);
        }

        //m = target.Length, n= wordBank.Count
        //TC: O(n * m2)
        //SC: O(m^2)
        private static int DPHelper(string target, List<string> wordBank, Dictionary<string, int> cache)
        {
            if (target.Length == 0) return 1;
            if (cache.ContainsKey(target)) return cache[target];
            int totalCount = 0;
            for (int i = 0; i < wordBank.Count; i++)
            {
                if(target.IndexOf(wordBank[i]) == 0)
                {
                    string newTarget = target.Substring(wordBank[i].Length);
                    int numWaysForRest = DPHelper(newTarget, wordBank, cache);
                    totalCount += numWaysForRest;
                    //if(cache.ContainsKey(newTarget))
                    //{
                    //    cache[newTarget] = totalCount;
                    //}
                    //else
                    //{
                    //    cache.Add(newTarget, totalCount);
                    //}
                }
            }
            if (cache.ContainsKey(target))
            {
                cache[target] = totalCount;
            }
            else
            {
                cache.Add(target, totalCount);
            }
            return totalCount;
        }

        //m = target.Length, n= wordBank.Count
        //TC: O(n^m * m)
        //SC: O(m^2)
        public static int CountConstructRecursion(string target, List<string> wordBank)
        {
            if (target.Length == 0) return 1;
            int totalCount = 0;
            for(int i=0;i<wordBank.Count;i++)
            {
                if(target.IndexOf(wordBank[i]) == 0)
                {
                    string newTarget = target.Substring(wordBank[i].Length);
                    int numWaysForRest = CountConstructRecursion(newTarget, wordBank);
                    totalCount += numWaysForRest;
                }
            }
            return totalCount;
        }

    }
}
