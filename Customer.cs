using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
  public class customer
    {
        // Member Variables
        public int CustID;
        public string Name;
        public string Address;

        //constuctor for initializing fields
        public customer()
        {
            CustID = 1101;
            Name = "Tom";
            Address = "USA";
        }

        static private int x;

        //constuctor for static initializing fields
        static customer()
        {
            x = 10;
        }
        //method for get  static field
        static public void getDataStatic()
        {
            Console.WriteLine("getDataStatic:" + x.ToString());
        }

        //Static constructors are parameterless. Static constructors can't be overloaded.
        //There is no accessibility specified for Static constructors.

        //constuctor for initializing fields
        public customer(string fname, string lname)
        {
            Name = fname + " " + lname;
        }
        //method for displaying customer records
        public void AppendData()
        {
            Console.WriteLine(Name);
        }

        //method for displaying customer records (functionality)
        public void displayData()
        {
            Console.WriteLine("Customer=" + CustID);
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Address=" + Address);
        }
        //method to release resource explicitly
        public void Dispose()
        {
            Console.WriteLine("Fields cleaned");
            x = 0;
        }
        //destructor destructor is prefixed with a tilde (~). There are some limitations of destructors as in the following;
        //Destructors are parameterless.   A Destructor can't be overloaded. Destructors are not inherited.
        //Destructors can cause performance and efficiency implications.
        ~customer()
        {
            Dispose();
        }


        //Function Overloading
        public string name;
        public void setName(string last)
        {
            name = last;
        }

        public void setName(string first, string last)
        {
            name = first + "" + last;
        }

        public void setName(string first, string middle, string last)
        {
            name = first + "" + middle + "" + last;
        }



    }
}
