using System;


namespace GettingStartedWithCSharp
{
    //  This program demo. how to declare a variable with dynamic keyword.
    class DynamicTypeDemo
    {
        static void Main()
        {
            dynamic num = 50;
            dynamic str = "string";
            Console.WriteLine($"num={num}\tstr={str}");
            Console.WriteLine($"type of num is:{num.GetType()}\ttype of str is:{str.GetType()}");
            Console.ReadLine();
        }
    }
}
