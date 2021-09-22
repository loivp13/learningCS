using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class MoreIenumerable
    {
        public IEnumerable<int> GetCollection(int option)
        {
            //create a list of numbers and init it
            List<int> numberList = new List<int>()
            {
                1,2,3,4,5
            };

            Queue<int> numbersQueue = new Queue<int>();
            //add values to the queue;
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            //option 1
            if(option == 1)
            {
                //return list of type List<int>
                return numberList;
                
            //option 2
            }else if (option == 2)
            {
                //return the Queue<int>
                return numbersQueue;
            }
            else
            {
                //return array of some nums
                return new int[] { 11, 12, 13, 14, 15 };
            }
        }
    }
}
