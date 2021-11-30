using System;


namespace GettingStartedWithCSharp
{
    //  This program demo how to declare const
    class ConstDemo
    {
        static void Main()
        {
            //  Const ust be intialized
            const double PI=3.14;
            //PI = 3.14; //Error

            int r = 5;
            double aoc =(r*r*PI);
            Console.WriteLine($"Area of Circle is:{aoc}");
            Console.ReadLine();
        }
    }
}
