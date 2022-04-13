using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class MyProgramDelegate
    {
        delegate void Foo();



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
        ////    }
        ////    static string Append(string firstName, string lastName)
        ////    {
        ////        return firstName + lastName;
        ////    }
        ////}

    //https://www.tutorialspoint.com/what-is-the-difference-between-func-delegate-and-action-delegate-in-chash
    //Func is a generic delegate included in the System namespace.It has zero or more input parameters and one out parameter.The last parameter is considered as an out parameter.This delegate can point to a method that takes up to 16 Parameters and returns a value.
    //Below is the Func delegate with two input and an output parameter.   //Func<string, string, string> Append;
    //Output MichaelJackson
    class ProgramDelegatFunc
        {
            static void Main(string[] args)
            {
                Func<string, string, string> func = Append;
                string fullName = func("Michael", "Jackson");
                Console.WriteLine(fullName);
                Console.ReadLine();
            }
            static string Append(string firstName, string lastName)
            {
                return firstName + lastName;
            }
        }

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


