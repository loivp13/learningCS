using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class StartProgram
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            //box.length = 3;
            box.SetLength(4);
            box.height = 4;
            box.width = 5;
            box.DisplayInfo();
        }
    }
}
