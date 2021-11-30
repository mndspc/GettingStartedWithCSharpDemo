using System;


namespace GettingStartedWithCSharp
{
    //  This program demo how to perform explicit type casting
    class ExplicitTypeCastDemo
    {
        static void Main()
        {
            double d = 45.7;
            //int num =(int) d;
            int num = Convert.ToInt32(d);
            string str = "40";
            int num1 = Convert.ToInt32(str);
            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.ReadLine();
        }
    }
}
