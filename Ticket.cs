using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class Ticket:IEquatable<Ticket>
    {
        public int DurationHours { get; set; }

        public Ticket(int durationHours)
        {
            DurationHours = durationHours;
        }
        
        public bool Equals(Ticket other)
        {
            return this.DurationHours == other.DurationHours;
        }
    }
}
