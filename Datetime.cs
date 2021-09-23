using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class Datetime
    {
        public static void WriteTime()
        {
            DateTime dateTime = new DateTime(1990, 5, 23);
            Console.WriteLine($"{dateTime}");
             
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
}
