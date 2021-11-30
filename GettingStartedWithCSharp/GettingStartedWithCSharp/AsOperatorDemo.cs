using System;


namespace GettingStartedWithCSharp
{
    //  This program demo. how to use as operator
    class AsOperatorDemo
    {
       static void Main()
        {
            object[] objArray = {"string1", "string2", "string3" };
            string str1 = objArray[0] as string;
            Console.WriteLine(str1);
            Console.ReadLine();
        }
    }
}
