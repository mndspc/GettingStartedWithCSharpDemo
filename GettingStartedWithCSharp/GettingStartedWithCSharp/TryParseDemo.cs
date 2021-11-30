using System;


namespace GettingStartedWithCSharp
{
    //  This program demo how to convert string into an int using TryParse()
    class TryParseDemo
    {
        static void Main()
        {
            //string str = "45";
            //string str = "a45";
            string str = "4534543543454";
            int result;
            bool isCompitible = int.TryParse(str, out result);
            if (isCompitible)
            {
                Console.WriteLine($"After converting string into an int:{result}");
            }
            else
            {
                Console.WriteLine("value is not compitible to convert into an int");
            }

            Console.ReadLine();
        }
    }
}
