using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms.String
{
    internal class BackSpaceStringCompare
    {
        public static void NotMain(string[] args)
        {
            //bool a = BackSpaceCompare("ab##", "c#d#");
        }

        //https://leetcode.com/problems/backspace-string-compare/
        public static bool BackSpaceCompare(string s, string t)
        {
            int si = s.Length - 1;
            int ti = t.Length - 1;
            int sCount = 0;
            int tCount = 0;
            while(si >= 0 || ti >= 0)
            {
                char sch = '$';
                while(sch == '$' && si >=0)
                {

                    if(s[si] != '#' && sCount == 0)
                    {
                        sch = s[si];
                    }
                    else if (s[si] != '#' && sCount > 0)
                    {
                        sCount--;
                    }
                    else if (s[si] == '#')
                    {
                        sCount++;
                    }
                    si--;
                }

                char tch = '$';
                while (tch == '$' && ti >= 0)
                {
                    if (t[ti] != '#' && tCount == 0)
                    {
                        tch = t[ti];
                    }
                    else if (t[ti] != '#' && tCount > 0)
                    {
                        tCount--;
                    }
                    else if (t[ti] == '#')
                    {
                        tCount++;
                    }
                    ti--;
                }

                if (sch != tch) return false;
                
            }
            return true;
        }
    }
}
