using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.DynamicProgramming
{
    class AllConstruct
    {
        public static void Main(string[] args)
        {
            Print(AllConstructRecursion("purple", new List<string> { "purp", "p", "ur", "le", "purpl" })); //2
            Print(AllConstructRecursion("abcdef", new List<string> { "ab", "abc", "cd", "def", "abcd","ef", "c" })); //4
            Print(AllConstructRecursion("skateboard", new List<string> { "bo", "rd", "ate", "t", "ska", "sk", "boar" })); // 0
            Print(AllConstructRecursion("enterapotentpot", new List<string> { "a", "p", "ent", "enter", "ot", "o", "t" })); //4
            Print(AllConstructRecursion("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new List<string> { "e", "ee", "eee", "eeee" }));//0
        }
        public static void Main(string args)
        {

        }

        // TC:
        // SC:
        private static List<List<string>> AllConstructRecursion(string target, List<string> wordBank)
        {
            List<List<string>> result = new List<List<string>>();
            AllConstructRecursion(target, wordBank, result, new List<string>());
            return result;
        }

        public static void AllConstructRecursion(string target, List<string> wordBank, List<List<string>> result, List<string> temp)
        {
            if(target.Length == 0)
            {
                result.Add(new List<string>(temp));
            }

            for(int i=0;i<wordBank.Count;i++)
            {
                if(target.IndexOf(wordBank[i]) == 0)
                {
                    string newTarget = target.Substring(wordBank[i].Length);
                    temp.Add(wordBank[i]);
                    AllConstructRecursion(newTarget, wordBank, result, temp);
                    temp.RemoveAt(temp.Count - 1);
                    //if (AllConstructRecursion(newTarget, wordBank) != null)
                    //{
                    //    temp.Add(wordBank[i]);
                    //}
                }
            }
        }


        private static void Print(List<List<string>> input)
        {
            foreach (var stringList in input)
            {
                foreach(var str in stringList)
                {
                    Console.Write(str + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
