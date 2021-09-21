using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class List1
    {
        static void test()
        {
           var strings2 = new List<string> { "hi","there"};
            var strings = new List<string> ();

            List<int> myList = new List<int>();
            for (int i = 100; i < 170; i++)
            {
                if(i %2 == 0)
                {
                    myList.Add(i);
                }
            }
        }
    }
}
