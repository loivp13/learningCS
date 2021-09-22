using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class MoreMoreIenumerable
    {
        public void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;

            foreach (int num in anyCollection)
            {
                sum+= num;
            }
            Console.WriteLine($"Sum is{sum}");
        }
    }
}
