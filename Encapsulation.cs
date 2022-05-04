using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOPS
{
    class Encapsulation
    {

        /// <summary>
        /// Every member Variable and Function of the class are bind
        /// with the Encapsulation class object only and safe with
        /// the outside inference
        /// </summary>

        // Encapsulation Begin
        int x;

        //class constructor
        public Encapsulation(int iX)
        {
            this.x = iX;
        }

        //calculating the square
        public void MySquare()
        {
            int Calc = x * x;
            Console.WriteLine("EncapsulationMySquare:"+ Calc.ToString() );
            
        }

        public int MySquare(int x)
        {
            int Calc = x * x;
            //Console.WriteLine("EncapsulationMySquare:" + Calc.ToString());
            return Calc;

        }

    }
}
