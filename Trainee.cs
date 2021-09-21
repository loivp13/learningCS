using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class Trainee : Employees
    {
        protected int WorkinHours { get; set; }
        protected int StudyHours { get; set; }
        public Trainee(string lastName, string firstName, int salary, int workingHours, int studyHours) : base(lastName, firstName, salary)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Salary = salary;

            this.WorkinHours = workingHours;
            this.StudyHours = studyHours;
        }
        public void Learn()
        {
            Console.WriteLine($"Studying hard for that dough. Working {WorkinHours} hours and studying {StudyHours} a day. {FirstName} {LastName} {Salary} ");
        }
    }
}
