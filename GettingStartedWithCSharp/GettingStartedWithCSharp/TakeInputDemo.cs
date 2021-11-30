using System;


namespace GettingStartedWithCSharp
{
    //  This program demo how to take input from user through console windows.
    class TakeInputDemo
    {
        static void Main()
        {
            Console.Write("Enter Product Amount:");
            int proAmount = int.Parse(Console.ReadLine());
            Console.Write("Enter GST Per:");
            double gstPer = Convert.ToDouble(Console.ReadLine());

            double gstAmt = proAmount / 100 * gstPer;
            Console.WriteLine($"GST Amount is:{gstAmt}");
            Console.ReadLine();
        }
    }
}
