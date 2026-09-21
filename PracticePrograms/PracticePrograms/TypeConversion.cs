using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class TypeConversion
    {
         public void ImplicitConversion()
        {
            int number = 10;
            double doubleNum = number;
            Console.WriteLine("number: {0} doubleNum:{1}",number,doubleNum);
        }

        public void ExplicitConversion()
        {
            double number = 101.23;
            int num = (int)number;
            Console.WriteLine("doubleNumber: {0} Number:{1}", number, num);
        }
    }
}
