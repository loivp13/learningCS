using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class StartProgram
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
            MainArgsDemo.RunMainArgs(args[0]);

            }
            else{
                Console.WriteLine("no good ");
            }
        }

        
    }
}
 