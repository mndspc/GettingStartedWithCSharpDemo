using System;


namespace GettingStartedWithCSharp
{
    //  This program demo. how to declare a variable with var keyword.
    class VarDemo
    {
        static void Main()
        {
            #region Dynamic variable
            //  dynamic may or may not be initialized
            dynamic num1 =null;
            #endregion

            #region Var variable
            // var must be initialized.
            var num =40;
          
            num1 = 50;
            var str = "string";
            var c = 'A';
            var flag = false;
            Console.WriteLine($"num={num}\tstr={str}\tc={c}\tflag={flag}");
            #endregion

            Console.ReadLine();
        }


        #region Public Functions

        //  we can use dynamic as return type for function but can
        public dynamic MyFun()
        {
            return null; 
        }

        public void MyFun1()
        {

        }
        #endregion
    }
}
