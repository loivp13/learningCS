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
        private int height;
        //public int width;
        public int volume;

        public int Width { get; set; }

        public int Height
        {
            get{
                return height;
            }
            set{
                if (value< 0)
                {
                    height = value;
                }
                height = value;
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}.", length, height,Width, volume=length*height*Width);
        }
        public void SetLength(int length)
        {
            if(length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
            this.length = length;
        }
        public int GetLength()
        {
            return this.length;
        }

    }
}
