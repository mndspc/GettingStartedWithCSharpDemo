using System;


namespace GettingStartedWithCSharp
{
    //  This program demo how to use Diff. Data Types
    class DataTypesDemo
    {
        static void Main()
        {
            int num = 60;
            double d = 56.7;
            char c = 'C';
            string str = "abc";
            bool flag = true;
            object intObj = 56;
            object strObj = "welcome";
            object charObj = 'A';
            Console.WriteLine($"int={num}\tdouble={d}\tchar={c}\tstring={str}\tbool={flag}");
            Console.ReadLine();
        }
    }
}
