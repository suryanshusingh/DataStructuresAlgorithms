using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.DynamicProgramming
{
    class CanConstruct
    {
        public static void NotMain(string[] args)
        {
            Console.WriteLine(CanConstructDP("abcdef", new List<string> { "ab", "abc", "cd", "def", "abcd" })); //true
            Console.WriteLine(CanConstructDP("skateboard", new List<string> { "bo", "rd", "ate", "t", "ska", "sk", "boar" })); // false
            Console.WriteLine(CanConstructDP("enterapotentpot", new List<string> { "a", "p", "ent", "enter", "ot", "o", "t" })); //true
            Console.WriteLine(CanConstructDP("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new List<string> { "e", "ee", "eee", "eeee" }));//false

            Console.WriteLine();

            Console.WriteLine(CanConstructRecursion("abcdef", new List<string> { "ab", "abc", "cd", "def", "abcd" })); //true
            Console.WriteLine(CanConstructRecursion("skateboard", new List<string> {"bo", "rd","ate","t","ska","sk","boar" })); // false
            Console.WriteLine(CanConstructRecursion("enterapotentpot", new List<string> { "a", "p", "ent", "enter", "ot", "o", "t" })); //true
            Console.WriteLine(CanConstructRecursion("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new List<string> { "e", "ee", "eee", "eeee" }));//false 
            // this will take forever
        }

        //m = target.Length, n= wordBank.Count
        //TC: O(n * m2)
        //SC: O(m^2)
        private static bool CanConstructDP(string target, List<string> wordBank)
        {
            Dictionary<string, bool> cache = new Dictionary<string, bool>();
            return DPHelper(target, wordBank, cache);
        }

        private static bool DPHelper(string target, List<string> wordBank, Dictionary<string, bool> cache)
        {
            if (target.Length == 0)
            {
                return true;
            }
            if (cache.ContainsKey(target)) return cache[target];

            for (int i = 0; i < wordBank.Count; i++)
            {
                if (target.IndexOf(wordBank[i]) == 0)
                {
                    string newTarget = target.Substring(wordBank[i].Length);
                    if (DPHelper(newTarget, wordBank, cache))
                    {
                        if (!cache.ContainsKey(newTarget)) cache.Add(target, true);
                        return true;
                    }
                }
            }
            if (!cache.ContainsKey(target)) cache.Add(target, false);
            return false;
        }
        //m = target.Length, n= wordBank.Count
        //TC: O(n^m * m)
        //SC: O(m)
        private static bool CanConstructRecursion(string target, List<string> wordBank)
        {
            if(target.Length == 0)
            {
                return true;
            }
            for(int i = 0;i<wordBank.Count;i++)
            {
                if(target.IndexOf(wordBank[i]) == 0)
                {
                    string newTarget = target.Substring(wordBank[i].Length);
                    if (CanConstructRecursion(newTarget, wordBank)) return true;
                }
            }
            return false;
        }
    }
}
