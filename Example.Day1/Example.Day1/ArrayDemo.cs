using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Day1
{
    internal class ArrayDemo
    {
        int[] NumbersArray;
        int[,] MatrixArray;

        public void StoreMatrix()
        {
            Console.WriteLine("Enter Row size:");
            int rowCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Column size:");
            int colCount = int.Parse(Console.ReadLine());

            MatrixArray=new int[rowCount,colCount];

            Console.WriteLine("Array Elements:");
            for(int i=0;i<rowCount;i++)
            {
                for(int j=0;j<colCount;j++)
                {
                    MatrixArray[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < MatrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixArray.GetLength(1); j++)
                {
                    Console.WriteLine(MatrixArray[i,j] + "\t");
                }

                Console.WriteLine("\n");
            }
            Console.WriteLine();
        }
        public void StoreNumbers()
        {
            Console.WriteLine("Enter size:");
            int count = int.Parse(Console.ReadLine());
            NumbersArray = new int[count];

                for (int i = 0; i < count; i++)
            {
                NumbersArray[i] = int.Parse(Console.ReadLine());
            }
        }

        public void printNumbers()
        {
            for (int i = 0; i < NumbersArray.Length; i++)
            {
                Console.WriteLine(NumbersArray[i]);
            }
        }
    }
}
