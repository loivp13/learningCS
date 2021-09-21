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
            Employees Sam = new Employees("Smith", "Sam", 60000);
            Boss Rod = new Boss("Hammer", "Rod", 1200000, "Big Wheel Truck");
            Trainee Billy = new Trainee("Poor", "Billy", 100, 20, 60);

            Sam.Work();
            Sam.Pause();

            Rod.Work();
            Rod.Pause();
            Rod.Lead();

            Billy.Work();
            Billy.Pause();
            Billy.Learn();
        }

        
    }
}
 