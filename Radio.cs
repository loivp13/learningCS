using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    //CHILD
    class Radio : ElectricalDevice
    {
        //INHERIANCE 
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {
        }
    }
}
