using System.Collections.Generic;

namespace LearningVisualStudioC
{
    internal class Queue
    {
        private static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>;
            queue.Enqueue(1);
            queue.Enqueue(2); // [1,2]
            //CHECK IF CONTAINS OR WILL CRASH
            if (queue.Count > 0)
            {
                queue.Dequeue(); //[2]
            }
        }
    }
}