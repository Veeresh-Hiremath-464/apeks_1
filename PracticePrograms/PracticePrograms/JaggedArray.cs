using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class JaggedArray
    {
        public void Jagged()
        {
            string[][] employeeSchedules = new string[4][];
            employeeSchedules[0] = new string[] { "Mon", "Tue" };
            employeeSchedules[1] = new string[] { "Mon", "Tue" ,"Thur"};
            employeeSchedules[2] = new string[] { "Mon" };
            employeeSchedules[3] = new string[] { "Mon", "Tue" ,"Friday","Sat"};

            for (int i = 0; i < employeeSchedules.Length; i++)
            {
                for(int j=0;j< employeeSchedules[i].Length;j++)
                {
                    Console.Write("{0} ", employeeSchedules[i][j],"\t");
                }
                Console.Write("\n");
            }
        }
    }
}
