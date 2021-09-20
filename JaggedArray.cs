using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class JaggedArray
    {
        static void JaggedArray1(string[] args)
        {
            //declare jaggedArray
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[0] = new int[3];
            jaggedArray[0] = new int[2];

            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1,2,3 };
            jaggedArray[0] = new int[] {13,21 };

            //alternative way
            int[][] jaggedArray2 = new int[][] { 
                new int[] {2,3,5,7,11},
                new int[] { 1,2,3}
            };
            
        }
        public void JaggedArrayChallenge()
        {
            string[][] jaggedArray = new string[][]
            {
                new string[] {"lip", "mp"},
                new string[] {"sue", "mas" }
            };
        }
        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;

        }
    }
}
