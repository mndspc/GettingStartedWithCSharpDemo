using System;


namespace GettingStartedWithCSharp
{
    //  This program demo how to use is operator.
    class IsOperatorDemo
    {
        static void Main()
        {
            A a = new A();
            Console.WriteLine(a is B);
            B b = new B();
            Console.WriteLine(b is A);
            Console.ReadLine();
        }
    }
    class A
    {

    }
    class B:A
    {

    }
}
