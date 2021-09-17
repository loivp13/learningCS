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
            //Create an object of my class
            // and instance of Human
            //public allows to use other variable outisde of class
            Human Bro = new Human("Little", "Bro");
            Human Sis = new Human("Little", "Sis");
            Bro.IntroduceMyself();
            Sis.IntroduceMyself();


            Console.Read();
        }
    }
}
