using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{

    //A class can inherit and implement multiple interfaces but doesn't support multiple inheritances.

    //Base Class
    public class Father
    {

        //constructor
        public Father()
        {
            Console.WriteLine("Father class constructor");
        }

        public void FatherMethod()
        {
            Console.WriteLine("this property belong to Father");
        }
    }

    //Derived class
    public class Child : Father
    {
        public Child(): base()
        {
            Console.WriteLine("child class constructor");
        }
        public void ChildMethod()
        {
            Console.WriteLine("this property belong to Child");
        }
    }
    
   
}
