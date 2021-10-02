using System;

namespace DataStructuresAlgorithms
{
    class Program
    {
        static void NotMain(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            Console.WriteLine(linkedList.GetLengthRecursive());

            linkedList.Push(5);
            linkedList.Push(6);
            linkedList.Push(1);
            linkedList.Push(8);
            linkedList.Push(1);
            linkedList.Push(6);
            linkedList.Push(5);

            //linkedList.Append(10);
            linkedList.PrintList();
            
            Console.WriteLine(linkedList.IsPalindrome());
            //Console.WriteLine(linkedList.SearchCountRecursive(6));






            //Console.WriteLine(linkedList.GetMiddleValueUsing3rdApproach());
            //Console.WriteLine(linkedList.GetMiddleValueUsingLength());
            //Console.WriteLine(linkedList.GetNthValueFromLast2ndApproach(6));
            //Console.WriteLine(linkedList.GetNthValueFromLast2ndApproach(3));
            //Console.WriteLine(linkedList.GetNthValueFromLast2ndApproach(2));
            //Console.WriteLine(linkedList.GetNthValueFromLast2ndApproach(1));
            //Console.WriteLine(linkedList.GetNthValueFromLast2ndApproach(0));
            //Console.WriteLine(linkedList.GetNthValueFromLast2ndApproach(4));

            //Console.WriteLine(linkedList.GetNthValueRecursion(0));
            //Console.WriteLine(linkedList.GetNthValueRecursion(1));
            //Console.WriteLine(linkedList.GetNthValueRecursion(3));
            //Console.WriteLine(linkedList.GetNthValueRecursion(6));
            //Console.WriteLine(linkedList.GetNthValueRecursion(5));

            // Console.WriteLine(linkedList.GetNthValue(5));



            //Console.WriteLine(linkedList.SearchRecursive(5));
            //Console.WriteLine(linkedList.SearchRecursive(6));
            //Console.WriteLine(linkedList.SearchRecursive(1));
            //Console.WriteLine(linkedList.SearchRecursive(8));
            //Console.WriteLine(linkedList.SearchRecursive(4));


            //linkedList.DeleteValue(1);
            //linkedList.PrintList();
            //Console.WriteLine(linkedList.GetLengthRecursive());
            //linkedList.DeletePosition(4);            
            Console.WriteLine("Hello World!");
            System.Collections.Generic.LinkedList<string> b = new System.Collections.Generic.LinkedList<string>();
            Console.ReadLine();
            
        }
    }
}
