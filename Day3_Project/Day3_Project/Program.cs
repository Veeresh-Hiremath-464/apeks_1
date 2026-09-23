/*
 *  try block : Raise or throw only inbuilt exceptions=> Exception, null reference etc
 *  - Assume if there is some error and try block will find that error, and if u do Console.WriteLine, the code execution won't stop there
 *  --So need to create custom exception, and throw it
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demoObj = new Demo();
            demoObj.GetDetails();

            Console.WriteLine("===========================");
            Customer custObj = new Customer();
            custObj.StoreCoustomers();
            custObj.PrintCustomers();

            //Console.WriteLine("===========================");
            //custObj.Search();

            //Console.WriteLine("===========================");
            //custObj.Update();
            //custObj.PrintCustomers();

            //Console.WriteLine("===========================");
            //custObj.RemoveCust();
            //custObj.PrintCustomers();

            //Console.WriteLine("===========================");
            //custObj.InsertCust();
            //custObj.PrintCustomers();

            Console.WriteLine("==========HASHTABLES===============");
            State stateObj = new State();
            stateObj.StoreDetails();

            Console.WriteLine("===========Query==============");
            custObj.GetDetails();



        }
    }
}
