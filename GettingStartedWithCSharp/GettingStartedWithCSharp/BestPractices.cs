using System;


namespace GettingStartedWithCSharp
{
    //  Class and Method names should always be in PascalCase.
    class BestPractices
    {
        //  Method argument and Local variables should always be in CamelCase.
        public void MyMessage(string myStr)
        {
            const double PI = 3.14;

            //  Avoid the use of under score while naming identifiers.
            int my_int = 40;
            int myInt = 40;

            //  Avoid the use of System data types and prefer using the Predefined data types.
            Int32 num = 40;
            int num1 = 40;
            Int16 num2 = 50;
            short num3 = 60;

            if (true) 
            {
                Console.WriteLine("hello");
                for (int i = 0; i < 20; i++)
                {
                    if (true)
                    {
                        //  Always declare the variables as close as possible to their use.
                        int intNum = 20;
                        Console.WriteLine(intNum);
                    }
                }
            }
            
        }
    }


    //  Always prefix an interface with letter I.
    interface IFirst
    {

    }

    //  Always use the using keyword when working with disposable types.It automatically disposes the object when program flow leaves the scope.
}
