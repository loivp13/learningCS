using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class Employees
    {
        //field
        protected string LastName { get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }

        public Employees(string lastName, string firstName, int salary)
        {
            LastName = lastName;
            FirstName = firstName;
            Salary = salary;
        }



        //methods
        public void Work()
        {
            Console.WriteLine($"All work and no play. {FirstName} {LastName} {Salary}");
        }

        public void Pause()
        {
            Console.WriteLine($"Freedom!{FirstName} {LastName} {Salary}");
        }
    }

}
