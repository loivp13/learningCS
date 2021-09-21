using System;

namespace LearningVisualStudioC
{
    internal class Boss : Employees
    {
        protected string CompanyCar { get; set; }



        public Boss(string lastName, string firstName, int salary, string companyCar) : base(lastName, firstName, salary)

        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Salary = salary;
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine($"Look Ma, I'm leading. I also have a {CompanyCar} from the company.{FirstName} {LastName} {Salary}");
        }
    }
}