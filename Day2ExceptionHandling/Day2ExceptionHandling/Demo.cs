using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2ExceptionHandling
{
    internal class Demo
    {
        public void PrintNumber()
        {
            try
            {
                int[] numbers = new int[] { 10, 20, 30, 40, 50, 60 };
                for(int i=0;i<10;i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            catch(Exception ex) 
            {
                throw; //Rethrow exception to the next level
                //Console.WriteLine("Message:{0}", ex.Message);
                //Console.WriteLine("Details:{0}", ex.StackTrace);
            }
        }
        string Name;
        public void GetName()
        {
            //To prevent null reference(that is trying to compute length without having value for name
            try
            {
                if (Name.Length > 0)
                {
                    Console.WriteLine("Available");
                }
                else
                {
                    Console.WriteLine("Not available");
                }
            }
            catch (Exception e) { 
            
                Console.WriteLine("Message:{0}",e.Message);
                Console.WriteLine("Method:{0}", e.TargetSite);
                Console.WriteLine("Project:{0}", e.Source);
                Console.WriteLine("Details:{0}", e.StackTrace);
            }
        }
    }
}
