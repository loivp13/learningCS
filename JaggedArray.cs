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
    }
}
