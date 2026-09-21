using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Day1
{
    internal class Demo
    {
        public void TypeConversion()
        {
            

            int number = 100;

            //double doubleNumber =(double)number;   //type conversion
            double doubleNumber = number; //Implict conversion: smaller datatype to larger
            Console.WriteLine("Int {0} Double {1}", number, doubleNumber);

        }

        public void ConversionDemo()
        {
            double doubleNumber = 10000.01;
            int number = (int)doubleNumber; //explict conversion: larger datatype to smaller
            Console.WriteLine("Int {0} Double {1}", number, doubleNumber);
        }
    }
}
