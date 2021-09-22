using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    interface IDestroyable
    {
        //property to store the audio files of the destruction sound
        string DestructionSound { get; set; }

        void Destroy();
    }
}
