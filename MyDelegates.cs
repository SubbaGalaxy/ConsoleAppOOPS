using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppOOPS
{

    //delegate is a variable that holds reference to a method. It's function pointer of the reference type
    public delegate int MyDelegate(int val1, int val2);
    class MyProgramDelegate
    {
        delegate void Foo();

        public int DelegateMethodAdd(int a, int b)
        {
            return a + b;
        }

        static void One()
        {
            Console.WriteLine("In one..");
        }

        static void Two()
        {
            Console.WriteLine("In two..");
        }


        ////static void Main(string[] args)
        ////    {
        ////        Func<string, string, string> func = Append;
        ////        string fullName = func("Michael", "Jackson");
        ////        Console.WriteLine(fullName);
        ////        Console.ReadLine();

        ////        //----------------
        ////        Foo myDelegate = One;
        ////        myDelegate += Two;

        ////        myDelegate(); // Will call One then Two
        ////        //----------------
        ///         MyDelegate handler = DelegateMethodAdd;
        ///         int retInt = handler(3,4);
        ////    }
        ////    static string Append(string firstName, string lastName)
        ////    {
        ////        return firstName + lastName;
        ////    }
        ///
   }

        //--https://www.tutorialspoint.com/what-is-the-difference-between-func-delegate-and-action-delegate-in-chash
        //Func is a generic delegate included in the System namespace.It has zero or more input parameters and one out parameter.The last parameter is considered as an out parameter.This delegate can point to a method that takes up to 16 Parameters and returns a value.
        //Below is the Func delegate with two input and an output parameter.   //Func<string, string, string> Append;
        //Output MichaelJackson
        //class ProgramDelegatFunc
        //{
        //    static void Main(string[] args)
        //    {
        //        Func<string, string, string> func = Append;
        //        string fullName = func("Michael", "Jackson");
        //        Console.WriteLine(fullName);
        //        Console.ReadLine();
        //    }
        //    static string Append(string firstName, string lastName)
        //    {
        //        return firstName + lastName;
        //    }
        //}

        //Action Delegate
        //Action is a delegate type defined in the System namespace.An Action type delegate is the same as Func delegate except that the Action delegate doesn't return a value. In other words, an Action delegate can be used with a method that has a void return type. It can contain minimum 1 and maximum of 16 input parameters and does not contain any output parameter.
        //Below is the Func delegate with two input and an output parameter. //Func<string, string,> Print;
        //class ProgramDelegateAction
        //    {
        //        static void Main(string[] args)
        //        {
        //            Action func = AppendPrint;
        //            func("Michael", "Jackson");
        //            Console.ReadLine();
        //        }
        //        static void AppendPrint(string firstName, string lastName)
        //        {
        //            string fullName = firstName + lastName;
        //            Console.WriteLine($"{fullName}");
        //        }
        //    }

}




//----------------------
// Declare a delegate
/*
delegate void Del(int i, double j);
class MathClass
{
    static void Main()
    {
        MathClass m = new MathClass();
        // Delegate instantiation using "MultiplyNumbers"
        Del d = m.MultiplyNumbers;
        // Invoke the delegate object.
        Console.WriteLine("Invoking the delegate using 'MultiplyNumbers':");
        for (int i = 1; i <= 5; i++)
        {
            d(i, 2);
        }
        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
    // Declare the associated method.
    void MultiplyNumbers(int m, double n)
    {
        Console.Write(m * n + " ");
    }
}
*/

/* Output:
Invoking the delegate using 'MultiplyNumbers':
2 4 6 8 10
*/
//*************************************************************