using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Day1
{
    internal class JaggedArray
    {
        int[][] data = new int[2][];
        public void DisplayJaggedArray()
        {
            
            data[0] = new int[] { 1, 2, 3 };
            data[1] = new int[] { 1, 2 };

            for (int i = 0; i <data.Length; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    Console.WriteLine(data[i][j]);
                }
            }
        }


    }
}
