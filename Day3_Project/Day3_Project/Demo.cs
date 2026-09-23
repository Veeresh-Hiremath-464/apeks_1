using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Project
{
    internal class Demo
    {
        public void GetDetails()
        {
            ArrayList listObj=new ArrayList();
            Console.WriteLine(listObj.Capacity);
            
            listObj.Add(100);
            listObj.Add("Rocks");
            listObj.Add(4000.40);
            listObj.Add(true);
            listObj.Add("Sony");
            //As we are adding 5 elements: that is exceeding 4, so capacity will be 8
            Console.WriteLine(listObj.Capacity);
            Console.WriteLine(listObj.Count);

            //As we are adding 9 elements: that is exceeding 8, so capacity will be 16
            //listObj.Add("Rocks");
            //listObj.Add(4000.40);
            //listObj.Add(true);
            //listObj.Add("Sony");
            //Console.WriteLine(listObj.Capacity);
            //Console.WriteLine(listObj.Count);

            // object, variant(var) key words are used to accomodate any kind of values
            foreach (var item in listObj)
            {
                Console.WriteLine("{0}",item);
            }

            Console.WriteLine(listObj.Contains(4000.40));
            listObj.Remove(100);

            Console.WriteLine("=========================");
            foreach (var item in listObj)
            {
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine("=========================");
            double number = (double)listObj[1];
            var numbers = listObj[1];
            Console.WriteLine("{0}", number);
            Console.WriteLine("{0}", numbers);

            Console.WriteLine("=========================");
            listObj.Reverse();
            foreach (var item in listObj)
            {
                Console.WriteLine("{0}", item);
            }


          


        }
    }
}
