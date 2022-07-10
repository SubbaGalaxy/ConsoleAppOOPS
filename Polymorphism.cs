using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Hiding Methods
//If a method with the same signature is declared in both base and derived classes, but the methods are not declared as virtual and overriden respectively,
//then the derived class version is said to hide the base class version. In most cases, you would want to override methods rather than hide them.
//Otherwise .NET automatically generates a warning.

namespace ConsoleAppOOPS
{
    public abstract class Employee
    {
        public virtual void LeaderName()
        {
        }
    }

    public class hrDepart : Employee
    {
        public override void LeaderName()
        {
            Console.WriteLine("Mr. joneHRemployee");
        }
    }
    public class itDepart : Employee
    {
        public override void LeaderName()
        {
            Console.WriteLine("Mr. TomITemployee");
        }
    } 

    public class financeDepart : Employee
    {
        public override void LeaderName()
        {
            Console.WriteLine("Mr. LinusFINANCEemployee");
        }
    }

    //class PolymorphismDemo
    //{
    //    static void Main(string[] args)
    //    {
    //        hrDepart obj1 = new hrDepart();
    //        itDepart obj2 = new itDepart();
    //        financeDepart obj3 = new financeDepart();

    //        obj1.LeaderName();
    //        obj2.LeaderName();
    //        obj3.LeaderName();

    //        Console.ReadKey();
    //    }
    //}
}
