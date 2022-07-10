using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Dynamic;


namespace ConsoleAppOOPS
{
    public sealed class Singleton
    {

        //dynamic myObject = new ExpandoObject();
        //myObject.myParameter = "hello world";
        //Console.WriteLine(myObject.myParameter);

        //var v = new { Amount = 108, Message = "Hello" };   ///anonymous types 

        private static int counter = 0;
        private static Singleton objInstance = null;
        public static readonly object obj = new object();
        public static Singleton GetMyOnlyInstance
        {
            get
            {
                if (objInstance == null)   // double-checked locking // locks are expensive
                {
                    lock (obj)  //ensures only one thread enters into code block ., other will wait funtil first one completed
                    {
                        if (objInstance == null) //lazy initialization .. object will not be created until instance property invoked.
                            objInstance = new Singleton();
                    }
                }
                return objInstance;
            }
                
            
        }   

        private Singleton()
        {
            counter++;
            Console.WriteLine("Instance objects counter value:" + counter.ToString());
        }
        public void PrintDetails(string myMessage)
        {
            Console.WriteLine(myMessage);
        }

    }
    public  class NonSingleton
    {

        private static int counterNonSingleton = 0;     

        public NonSingleton()
        {
            counterNonSingleton++;
            Console.WriteLine("NonSingleton instance counter value:" + counterNonSingleton.ToString());
        }
        public void PrintDetails(string myMessage)
        {
            Console.WriteLine(myMessage);
        }

    }
}
