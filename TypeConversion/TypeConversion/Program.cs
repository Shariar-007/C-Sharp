using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            double d = 5673.74;
            int i;
            i = (int)d;
            Console.WriteLine(i);
            int  j= 75;
            float f = 53.005f;
            double g = 2345.7652;
            bool b = true;
      
            Console.WriteLine(j.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(g.ToString());
            Console.WriteLine(b.ToString());
            
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            double myDouble1 = 9.78;
            int myInt1 = (int)myDouble1;    // Manual casting: double to int

            int myInt2 = 10;
            double myDouble2 = 5.25;
            bool myBool3 = true;

            Console.WriteLine(Convert.ToString(myInt2));
            Console.WriteLine(Convert.ToDouble(myInt2));
            Console.WriteLine(Convert.ToInt32(myDouble2));
            Console.WriteLine(Convert.ToString(myBool3));

        }
    }
}
