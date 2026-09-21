using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class ArrayTypes
    {
        int[] SingleDim;
        int[,] MultiDim;

        public void StoreValues()
        {
            Console.WriteLine("Enter the array size:");
            int size = int.Parse(Console.ReadLine());
            SingleDim = new int[size];
            
            //Take input of size elements
            for(int i=0;i<size;i++)
            {
                SingleDim[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Print()
        {
            for (int i = 0; i < SingleDim.Length; i++)
            {
                Console.WriteLine("Number {0}:{1}", i, SingleDim[i]);
            }
        }

        public void StoreMatrix()
        {
            Console.WriteLine("Enter the row size:");
            int rowSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Column size:");
            int colSize = int.Parse(Console.ReadLine());
            MultiDim = new int[rowSize, colSize];

            //Take input of size elements
            for (int i = 0; i < rowSize; i++)
            {
                for(int j=0;j<colSize;j++)
                {
                    MultiDim[i,j]=int.Parse(Console.ReadLine());
                }

            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < MultiDim.GetLength(0); i++)
            {
                for (int j = 0; j< MultiDim.GetLength(1); j++)
                {
                    Console.Write("{0} ", MultiDim[i,j],"\t");
                }
                Console.Write("\n");
                    
            }
        }
    }
}
