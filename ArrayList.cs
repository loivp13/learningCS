using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class ArrayListTest
    {
        public static void ArrayListTest1()
        {
            //unlimited list
            ArrayList myArrList = new();
            //limited list
            ArrayList myArrList2 = new (100);

            myArrList.Add(25);
            myArrList.Add("what");
            myArrList.Add(13.37);
            myArrList.Add(13);
            myArrList.Add(25.3);

            //delete element with specific value from the array list
            myArrList.Remove(13);

            //delete element at specific position
            myArrList.RemoveAt(0);
            Console.WriteLine(myArrList.Count);

            double sum = 0;
            foreach (object obj in myArrList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }else if(obj is double)
                {
                    sum +=(double) obj;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
