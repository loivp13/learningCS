using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class ElectricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        public void SwitchOff()
        {

            IsOn = false;
        }

        public void MyMethod()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the Radio");
            }
            else
            {
                Console.WriteLine("Radio is switched off, switch it on first.");
            }
            throw new NotImplementedException();
        }
    }
}
