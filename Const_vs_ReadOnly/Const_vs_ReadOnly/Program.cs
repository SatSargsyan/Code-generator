using System;

namespace Const_vs_ReadOnly
{
    class Program
    {
        //class_example for READONLY
        public class Test
        {
            public readonly int rdOnly = 3;
            public Test(int rdVal)
            {
                rdOnly = rdVal;
                Console.WriteLine(rdOnly);
            }

            public Test()
            {
                rdOnly = 5;
                Console.WriteLine(rdOnly);
            }

            public Test(string s)
            {
                Console.WriteLine(s);
                Console.WriteLine(rdOnly);
            }
            //class_example for STATIC READONLY
            public static class Test1
            {
                public static readonly int rdOnly1 = 3;

                //static class can has only one constructor,
                //1. it must be parameterless, 2.it cannot be public
                static Test1()
                {
                    rdOnly1 = 15;
                    Console.WriteLine(rdOnly1);
                }

                public static int Ab(int a)
                {
                    return a;
                }
                public static void Main()
                {
                    Test test1 = new Test(100);
                    //100

                    Test test2 = new Test();
                    //5

                    Test test3 = new Test("Hello");
                    //Hello
                    //3

                    //test3.rdOnly = 2000;
                    //compile error

                    Console.WriteLine(Test1.rdOnly1);
                    Console.ReadKey();
                }
            }
        }
    }
}
