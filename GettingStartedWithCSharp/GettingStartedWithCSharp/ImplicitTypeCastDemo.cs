using System;


namespace GettingStartedWithCSharp
{
    // This program demo how to perform implicit conversion
    class ImplicitTypeCastDemo
    {
        static void Main()
        {
            int num = 40;
            double d = num; //implicit conversion
            Console.WriteLine(d);
            Console.ReadLine();

        }
    }
}
