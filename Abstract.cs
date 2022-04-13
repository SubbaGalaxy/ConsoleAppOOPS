using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //abstract class
    //abstract class C# allows both classes and functions to be declared abstract using the abstract keyword. You can't create an instance of an abstract class.
    //An abstract member has a signature but no function body and they must be overridden in any non-abstract derived class. Abstract classes exist primarily for inheritance.
    //Member functions, properties and indexers can be abstract. A class with one or more abstract members must be abstract as well. Static members can't be abstract.
    //we are declaring an abstract class Employess with a method displayData() that does not have an implementation. Then we are implementing the displayData() body
    //in the derived class. One point to be noted here is that we have to prefixe the abstract method with the override keyword in the derived class.
    public abstract class Employess
    {
        //abstract method with no implementation
        public abstract void displayData();
    }

    //derived class
    public class test : Employess
    {
        //abstract class method implementation
        public override void displayData()
        {
            Console.WriteLine("Abstract class method");
        }
    }
}
