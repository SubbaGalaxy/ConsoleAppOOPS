using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{

    //Static classes - A static class is declared using the "static" keyword.
    //If the class is declared as static then the compiler never creates an instance of the class.
    //All the member fields, properties and functions must be declared as static and they are
    //accessed by the class name directly not by a class instance object.
    static class StaticClass
    {
        //A constructor can be static. You create a static constructor to initialize static
        //fields. Static constructors are not called explicitly with the new statement.
        //They are called when the class is first referenced.
        //There are some limitations of the static constructor as in the following;
        //Static constructors are parameterless.
        //Static constructors can't be overloaded.
        //There is no accessibility specified for Static constructors.

        //static fields
        static int x = 10, y=0;

        //constuctor for static initializing fields //Static constructors are parameterless.
        static StaticClass()
        {
            x = 100;
        }

        //static method
        static public void clsStaticProduct() //look to access outside this class --- only public allowed
        {
            y = x * x;
            Console.WriteLine("clsStaticProductPublic:"+ y.ToString());
        }
        //static void Main(string[] args)
        //{
        ////function calling directly
        //StaticClass.clsStaticProduct();
        //}
    }
}
