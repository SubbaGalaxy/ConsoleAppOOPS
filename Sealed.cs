using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    //https://https://www.c-sharpcorner.com/UploadFile/84c85b/object-oriented-programming-using-C-Sharp-net/
    //https://digitash.com/learntips/topic/how-to-quickly-split-screen-on-windows-10-into-2-3-4/
    //Sealed classes are the reverse of abstract classes. While abstract classes are inherited and
    //are refined in the derived class, sealed classes cannot be inherited. You can create an instance
    //of a sealed class. A sealed class is used to prevent further refinement through inheritance.

    sealed class SealedClass
    {
        public void myfuncSealed()
        {
            Console.WriteLine("from myfuncSealedclass, sealed class canno tbe inherited");
        }
    }

    //public class test : SealedClass //wrong. will give compilation error
    //{
    //}
}
