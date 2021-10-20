using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAlgorithms
{
    class Static
    {
        // The main method is always static because we dont want the c# complier to create an object first.
        public static void NotMain(string[] args)
        {
            A obj = new A();
            obj.IncreaseBy1();
            Console.WriteLine(obj.ValueOfa()); //11

            A obj2 = new A();
            obj2.IncreaseBy1();
            Console.WriteLine(obj.ValueOfa()); //12

            A.StaticMethod();

            Console.WriteLine("print");
        }


    }

    class A
    {
        // This cannot be accessed in c#, but can be accessed in java
        // This would be allocated memory only once for all the objects of this class, so if value is increased once, it will be increased at another places also.
        public static int a = 10;

        public int aa = 10;

        public void IncreaseBy1()
        {
            a++;
        }

        public int ValueOfa()
        {
            return a;
        }

        // this can be called without making any object.
        // Static methods cannot access non static variables.
        public static void StaticMethod()
        {       
            var b = a;
            
            //Error
            //var bb = aa;
        }
    }
}
