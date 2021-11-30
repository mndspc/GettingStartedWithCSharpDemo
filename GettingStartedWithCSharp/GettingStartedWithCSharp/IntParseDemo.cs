using System;


namespace GettingStartedWithCSharp
{
    //  This program demo how to convert string into int using int.Parse()
    class IntParseDemo
    {
        static void Main()
        {
            try
            {
                //string str = "30";
                //string str="a30";
                string str = "5454645654645";
                int num = int.Parse(str);
                Console.WriteLine($"After converting string into an int:{num}");
            }catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
