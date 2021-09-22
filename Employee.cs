using System;
using System.Collections.Generic;

namespace LearningVisualStudioC
{
    internal class Employees : IDestroyable
    {
        //field
        protected string LastName { get; set; }

        protected string FirstName { get; set; }
        protected int Salary { get; set; }
       

        public Employees()
        {
        }

        //Interface destruction
        public string DestructionSound { get; set; }

        //store all destoryable object nearby
        //list sotre any object that implements this interface, can only access properties and method in this intreface
        public List<IDestroyable> DestoryablesNearby;
        public Employees(string lastName, string firstName, int salary)
        {
            LastName = lastName;
            FirstName = firstName;
            Salary = salary;

            //initialize the interface's property with a value in the constructor
            DestructionSound = "CarExplosionSound.mp3";
            DestoryablesNearby = new List<IDestroyable>();
        }

        //implementing the interface's method
        public void Destory()
        {
            Console.WriteLine($"{DestructionSound}");
            foreach (IDestroyable destroyable in DestoryablesNearby)
            {
                destroyable.Destroy();
            }
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

        void IDestroyable.Destroy()
        {
            throw new NotImplementedException();
        }
    }
}