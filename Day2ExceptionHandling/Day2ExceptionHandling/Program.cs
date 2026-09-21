using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Demo demoObj = new Demo();
                demoObj.GetName();
                demoObj.PrintNumber();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message:{0}", ex.Message);
                Console.WriteLine("Details:{0}", ex.StackTrace);
            }
           
        }
    }
}
