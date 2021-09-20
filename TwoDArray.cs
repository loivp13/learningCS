using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class TwoDArray
    {
        static int[,] matrix =
        {
            {1,2,3,},
            {4,5,6 },
            {7,8,9 }
        };
       static void TwoDArray1(string[] args)
        {
            foreach (int item in matrix)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("this is 2d array printed using nested for loop");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(i + j == 2)
                    {

                    Console.WriteLine(matrix[i,j]);
                    }
                }
            }

        }
    }
}
