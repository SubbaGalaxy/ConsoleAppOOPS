using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class myBase
    {
        //By declaring a base class function as virtual, you allow the function to be overridden
        //in any derived class. The idea behind a virtual function is to redefine the implementation
        //of the base class method in the derived class as required.If a method is virtual in the base class
        //then we have to provide the override keyword in the derived class.
        //Neither member fields nor static functions can be declared as virtual.
        //virtual function

        //Neither member fields nor static functions can be declared as virtual

        public virtual void VirtualMethod()
        {
            Console.WriteLine("virtual method defined in the base class");
        }
    }

    class myDerived : myBase
    {
        // redifing the implementation of base class method
        public override void VirtualMethod()
        {
            Console.WriteLine("virtual method defined in the Derive class");

            // hiding the implementation of base class method  ***READ
            //still access the base class method
            base.VirtualMethod();
        }
    }

    //Hiding Methods : If a method with the same signature is declared in both base and derived classes, but the methods are not declared as virtual and overriden respectively, then the derived class version is said to hide the base class version. In most cases, you would want to override methods rather than hide them.Otherwise.NET automatically generates a warning.


    //class virtualClass
    //{
    //    static void Main(string[] args)
    //    {
    //        // class instance  //virtualclass
    //        new myDerived().VirtualMethod();
    //        Console.ReadKey();
    //    }
    //}
}
