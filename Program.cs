using System;
using System.Collections.Generic;
using System.Linq;


//https://www.c-sharpcorner.com/UploadFile/84c85b/object-oriented-programming-using-C-Sharp-net/
//https://www.c-sharpcorner.com/UploadFile/d6fefe/delegate-anonymous-function-and-lambda-expression-in-C-Sharp/#:~:text=And%20the%20main%20difference%20between%20C%2B%2B%20function%20pointers,the%20same%20as%20passing%20methods%20to%20another%20method.
//https://www.c-sharpcorner.com/blogs/delegate-vs-action-vs-func1

//None of the Func or Action types allow out or ref parameters, so you'll have to define your own delegates if you need to use those e.g.:
//public delegate bool TryParse<T>(string s, out T value);
//String objects are immutable: they can't be changed after they've been created.
//All of the String methods and C# operators that appear to modify a string actually return the results in a new string object.
//The statement that a string is immutable means that, once created, it is not altered by changing the value assigned to it.
//StringBuilder is the mutable string type. It will not create a new modified instance of the current string object but do the modifications in the existing string object.
//arrays are mutable
namespace ConsoleAppOOPS
{
    class Program
    {

        public void MainFunction()
        {
            Console.WriteLine("Main Program class");
        }
        //static fields
        static int x = 10, y;

        //static method
        static void Calculate()
        {
            y = x * x;
            Console.WriteLine(y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Main");
            //String string
            string testVal = "ByValue-In";
            string testOut = "strings are immutable and  Are Reference Types -  before passing"; //MustAssign if you are plannin gto pass as out parameter
            //string testOut;
            string testRef = "strings are immutable and  Are Reference Types -  before passing"; ////MustAssign
            Console.WriteLine(testOut);
            TestMyStringout(out testOut);
            Console.WriteLine(testOut);
            TestMyStringref(ref testRef);
            Console.WriteLine(testRef);
            TestMyStringvalue(testVal);
            Console.WriteLine(testVal);
            Console.ReadLine();

            /*  //extracted to different methods for calling Parrallel
            //singleton Pattern
            Singleton fromEmployee = Singleton.GetMyOnlyInstance;   // single instance created    /// Make It thread safe
            fromEmployee.PrintDetails("From employee SingletonGetMyOnlyInstance");  /// Here it is call ed one after other -- singl instanc ecreated //https://www.youtube.com/watch?v=QWrcOmLWi_Q
            
            Singleton fromStudent = Singleton.GetMyOnlyInstance; // same instance used 
            fromStudent.PrintDetails("from  Student SingletonGetMyOnlyInstance ");
            */
            //Called both methods parallel  //MultithreadEnvironment
            //Parallel.Invoke( 
            //    ()=> PrintStudentDetails(),
            //    ()=> PrintEmployeeDetails()
            //    );
            Console.ReadLine();
            //PrintStudentDetails();
            //PrintEmployeeDetails();

            //non singleton
            NonSingleton obj1 = new NonSingleton();
            obj1.PrintDetails("from obj1 ");

            NonSingleton obj2 = new NonSingleton();
            obj2.PrintDetails("from obj2 - second instance created");

            NonSingleton obj3 = new NonSingleton();
            obj3.PrintDetails("from obj3 - third instance created, check instance counter");

            Console.ReadLine();

            customer cObj = new customer();
            cObj.displayData();

            cObj.setName("barack");  // function overloading
            cObj.setName("barack ", " obama ");
            cObj.setName("barack ", "hussian", "obama");

            Console.WriteLine("------------------------");

            //function calling directly
            //Program.Calculate(); //not accessible

            //staticDemo

            // object instantiation
            customer obj = new customer("Barack", "Obama");
            //Method calling  //The moment a new statement is executed, the default constructor is called.
            obj.AppendData();

            demo dObj = new demo();
            dObj.addition();

            // array list

            var months = new List<string>();
            months.Add("January");
            months.Add("February");
            months.Add("March");
            months.Add("April");

            //using for loop
            for (int i = 0; i < months.Count; i++)
            {
                Console.WriteLine(months[i]);
            }

            //using foreach loop
            foreach (var month in months)
            {
                Console.Write(month);
            }
            Console.WriteLine("");

            //using linq forEach
            months.ForEach(month => Console.WriteLine(month));

            //using linq forEach with static functi
            months.ForEach(Console.WriteLine);

            //using strings.join
            Console.WriteLine(string.Join(", ", months));

            //Partial classes Typically, a class will reside entirely in a single file.However, in situations where multiple developers need access to the same class, then having the class in multiple files can be beneficial.The partial keywords


            partialclassDemo objPartial = new partialclassDemo();
            objPartial.method1();
            objPartial.method2();

            //********************** OOPS Concepta ***************

            Encapsulation objEnc = new Encapsulation(20);
            objEnc.MySquare();

            //------- inheritance -----
            //Here Child object can access both class methods  // Inheritance
            Child childObj = new Child(); // father Class constructor called
            childObj.FatherMethod(); // base class Father Method called
            childObj.ChildMethod();
            //--------Static method/static class---------            

            customer.getDataStatic();

            //function calling from StaticClass public method  directly
            StaticClass.clsStaticProduct();

            //-----------------

            // class instance  //virtualclass
            new myDerived().VirtualMethod();

            // class instance    //ABSTRACT class ***READ
            new test().displayData();

            //selaed Class
            SealedClass sealObj = new SealedClass();
            sealObj.myfuncSealed();   // but cannot derive // not extensible
                                      //----------------- interface ---------
            testInterface iObj = new testInterface();
            iObj.methodA();
            iObj.methodB();

            //-----  Polymorphism ----
            hrDepart objPoly1 = new hrDepart();
            itDepart objPoly2 = new itDepart();
            financeDepart objPoly3 = new financeDepart();

            objPoly1.LeaderName(); //Hr Dept leader - "Mr. joneHRemployee called   // at run time will which method to call
            objPoly2.LeaderName();// IT dept leader called - Mr. TomITemployee
            objPoly3.LeaderName(); // Fin Dept employee - Mr. LinusFINANCEemployee

            Employee A = objPoly3;  // finance called 
            A.LeaderName();  // Also calls the new method.
            Employee B = objPoly1;  // pointing to HR  // dynamic binding
            B.LeaderName();  // HR method called method.

            ////DerivedClass B = new DerivedClass();
            ////B.DoWork();  // Calls the new method.
            ////BaseClass A = B;
            ////A.DoWork();  // Also calls the new method.

            //Virtual methods and properties enable derived classes to extend a base class without needing to use the base class implementation of a method.

            Console.ReadKey();
            //generics
            //Generics; Iterators;LINQ Query Expressions;Namespaces;Unsafe Code and Pointers;XML Documentation Comments
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/
            //GenericList<float> list1 = new GenericList<float>();
            //GenericList<ExampleClass> list2 = new GenericList<ExampleClass>();
            //GenericList<ExampleStruct> list3 = new GenericList<ExampleStruct>();
            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions

            //C# 4  - introduces a new type, dynamic.The type is a static type, but an object of type dynamic bypasses static type checking. In most cases, it functions like it has type object.At compile time, an element that is typed as dynamic is assumed to support any operation.

            //ExampleClass ec = new ExampleClass();
            //// The following call to exampleMethod1 causes a compiler error
            //// if exampleMethod1 has only one parameter. Uncomment the line
            //// to see the error.
            ////ec.exampleMethod1(10, 4);

            //dynamic dynamic_ec = new ExampleClass();
            //// The following line is not identified as an error by the
            //// compiler, but it causes a run-time exception.
            //dynamic_ec.exampleMethod1(10, 4);

            //// The following calls also do not cause compiler errors, whether
            //// appropriate methods exist or not.
            //dynamic_ec.someMethod("some argument", 7, null);
            //dynamic_ec.nonexistentMethod();

            //class ExampleClass
            //{
            //    public ExampleClass() { }
            //    public ExampleClass(int v) { }

            //    public void exampleMethod1(int i) { }

            //    public void exampleMethod2(string str) { }
            //}


            //***********************************************
            //you cannot inherit from multiple classes
            /*
            interface Ia { }
            interface Ib { }
            class clsBase { }
            class clsAnother { }
            class SomeClass : Ia, Ib { } // from multiple Interface(s)
            class SomeClass : clsBase, Ib { } // from one Class and Interface(s)   ///multiple interfaces

            --//Illegal // class SomeClass : clsBase, clsAnother { }
            */

            //Note that you can write extension methods for interfaces, which can help to share implementation code.

            //*******123START**************
            //variables that are declared at method scope can have an implicit "type" var.An implicitly typed local variable is strongly typed
            //just as if you had declared the type yourself, but the compiler determines the type.
            // Example #1: var is optional when
            // the select clause specifies a string
                string[] words = { "apple", "strawberry", "grape", "peach", "banana" };
            var wordQuery = from word in words
                            where word[0] == 'g'
                            select word;

            // Because each element in the sequence is a string,
            // not an anonymous type, var is optional here also.
            foreach (string s in wordQuery)
            {
                Console.WriteLine(s);
            };

            //// Example #2: var is required because
            //// the select clause specifies an anonymous type
            /// <summary>

            //string[] customers = { "ATT", "VZ", "FIOS", "SPECTRUM", "TMOBILE" };
            //var custQuery = from cust in customers
            //                where cust.City == "Phoenix"
            //                select new { cust.Name, cust.Phone };


            //// var must be used because each item
            //// in the sequence is an anonymous type
            //foreach (var item in custQuery)
            //{
            //    Console.WriteLine("Name={0}, Phone={1}", item.Name, item.Phone);
            //}

            //    /// </summary>



            ////private static readonly PizzaInfo[] TheMenu = new[]
            ////{
            ////    new PizzaInfo { PizzaName = "The Mighty Meatball", Ingredients = "Meatballs and cheese", Cost = 40, InStock = "yes"},
            ////    new PizzaInfo { PizzaName = "Crab Apple", Ingredients = "Dungeness crab and apples", Cost = 35, InStock = "no"},
            ////    new PizzaInfo { PizzaName = "Forest Floor", Ingredients = "Mushrooms, rutabagas, and walnuts", Cost = 20, InStock = "yes"},
            ////    new PizzaInfo { PizzaName = "Don't At Me", Ingredients = "Pineapple, Canadian bacon, jalapeños", Cost = 25, InStock = "yes"},
            ////    new PizzaInfo { PizzaName = "Vanilla", Ingredients = "Sausage and pepperoni", Cost = 15, InStock = "no"},
            ////    new PizzaInfo { PizzaName = "Spice Coming At Ya", Ingredients = "Peppers, chili sauce, spicy andouille", Cost = 50, InStock = "yes"}
            ////};

        //string custQuery = from cust in PizzaInfo
        //                where cust.Ingredients == "Pineapple, Canadian bacon, jalapeños"
        //                   select new { cust.Name, cust.Phone };

        //*******123END**************


    }

    /////MyDelegate handler = DelegateMethodAdd; //instantiate the delegate



    private static int AddNumbers(int val1, int val2)
        {
            throw new NotImplementedException();
        }

        public static void TestMyStringvalue(string test)
        {
            test = "after passing value";
        }
        public static void TestMyStringout(out string test)
        {
            test = "after passing out";
        }

        public static void TestMyStringref(ref string test)
        {
            test = "after passing ref";
            //then when the reference changed we will see it outside the scope of the TestI(string) method.
            //ref = initialised outside function, out = initialised inside of function, or in other words; ref is two - ways, out is out-only.So surely ref should be used.

            //A string variable is a reference - type variable.Therefore, it contains a pointer to an instance stored elsewhere.
            //When passed-by - value, its pointer is copied, so modifying a string argument should affect the shared instance.
            //However, a string instance has no mutable properties, so a string argument cannot be modified anyway.
            //When passed-by - reference, the pointer's container is shared, so reassignment will still affect the external scope.

        }

        private static void PrintEmployeeDetails()
        {
            Singleton fromStudent = Singleton.GetMyOnlyInstance; // same instance used 
            fromStudent.PrintDetails("from  Student SingletonGetMyOnlyInstance ");
        }

        private static void PrintStudentDetails()
        {
            //singleton Pattern
            Singleton fromEmployee = Singleton.GetMyOnlyInstance;   // single instance created    /// Make It thread safe
            fromEmployee.PrintDetails("From employee SingletonGetMyOnlyInstance");  /// Here it is call ed one after other -- singl instanc ecreated //https://www.youtube.com/watch?v=QWrcOmLWi_Q
        }

       

        public static void TestI(ref string test)
        {
            string s1 = "abc";  //--- s1 pointing to abc
            string s2 = s1;     //--- s2 pointing to abc
            s1 = "def";
            Console.WriteLine(s2); // // Output: abc


            //unsafe
            //{
            //    string a = "Test";
            //    string b = a;
            //    fixed (char* p = a)
            //    {
            //        p[0] = 'B';
            //    }
            //    Console.WriteLine(a); // output: "Best"
            //    Console.WriteLine(b); // output: "Best"
            //}

            ////Yes, String is a reference type:    ***READ A reference-type variable contains a pointer to an instance stored elsewhere.

            // A passed-by - value argument is a new container with a new copy of the content.
            // A passed-by - reference argument is the original container with its original content.

        }


    }


    class demo
    {
        int x = 10;
        int y = 20;
        int z;

        public void addition()
        {
            z = x + y;
            Console.WriteLine("other Demo class in Namespace");
            Console.WriteLine(z);
        }

        public static void TestI(out string test)
        {
            test = "after passing";
        }
    }


    //-----------------------
    //Static classes - A static class is declared using the "static" keyword.
    //If the class is declared as static then the compiler never creates an instance
    //of the class. All the member fields, properties and functions must be declared
    //as static and they are accessed by the class name directly not by a class instance object.

    static public class staticDemo
    {
        //static fields
        static int x = 10, y;

        //static method
        static void Calculate()
        {
            y = x * x;
            Console.WriteLine(y);
        }
        //static void Main(string[] args)
        //{
        //    //function calling directly
        //    staticDemo.Calculate();
        //}
    }
    

  

}
