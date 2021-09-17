using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class Box
    {
        //member variable
        private int length;
        public int height;
        public int width;
        public int volume;

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}.", length, height,width, volume=length*height*width);
        }
        public void SetLength(int length)
        {
            this.length = length;
        }
        public int GetLength()
        {
            return this.length;
        }

    }
}
