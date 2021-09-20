using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class CreateArray
    {
        //one way to init arrays
        public int[] createArrV1;
        public int[] createArrV2;
        //assigning arrays
        public CreateArray(int value1)
        {
            this.createArrV1 = new int[value1];
            this.createArrV2 = new int[value1];


        }
    }
}
