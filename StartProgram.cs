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
            DogShelter shelter = new DogShelter();
            foreach (Dog dog in shelter)
            {
                if (!dog.IsBadDog)
                {
                    dog.GiveTreat(2);
                }else
                {
                    dog.GiveTreat(1);
                }
            }
        }

        
    }
}
 