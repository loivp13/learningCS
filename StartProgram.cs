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
            Cars defaultCar = new Cars(70,"blue","Default");
            Audi x70 = new Audi(300, "red", "x70");
            BMW is70 = new BMW(320, "yellow", "is70");
            x70.Repair();

            /*defaultCar.ShowDetails();
            defaultCar.Repair();

            x70.ShowDetails();

            is70.ShowDetails();
            is70.Repair();*/
            List<Cars> listCars = new List<Cars>();

            listCars.Add(x70);
            listCars.Add(defaultCar);
            listCars.Add(is70);

            foreach (Cars car in listCars)
            {
                car.Repair();
            }
        }

        
    }
}
 