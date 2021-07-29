using System;

namespace ConstantsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // veriable declearation
            object obj;
            obj = 100; //boxing

            dynamic d = 20;

            string str = "hello world";
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Size of int: {0}", sizeof(int));

            //The constants refer to fixed values that the program may not alter during its execution.
            Console.WriteLine("Hello World\t Hello World");

            const double pi = 3.14159;
            Console.WriteLine(pi);


        }
    }
}
