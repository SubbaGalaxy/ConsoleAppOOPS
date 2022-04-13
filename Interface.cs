using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    // interface    //delegates vs function 
    public interface Ixyz
    {
        void methodA();
        int methodA(int a);
        //string methodA(int a); // cannot have same parameter and same method
        //int methodA(int a); // cannot have same parameters and same methodname and different return type
        //string methodA(int a,string b); //ok to have
        void methodB();
    }

    // interface method implementation
    class testInterface : Ixyz
    {
        public void methodA()
        {
            Console.WriteLine("methodA");
        }
        public int methodA(int a)
        {
            Console.WriteLine(a.ToString()) ;
            return a;
        }
        public void methodB()
        {
            Console.WriteLine("methodB");
        }
    }
    //class interfaceDemo
    //{
    //    static void Main(string[] args)
    //    {
    //        testInterface obj = new testInterface();
    //        obj.methodA();
    //        obj.methodB();
    //    }
    //}

    public interface Iabc   //An interface can be inherited from other interfaces as in the following
    {
        void methodA();
        void methodB();
    }

    public interface Ipqr : Iabc
    {
        void methodC();
    }
    
}
