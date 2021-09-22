using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class IenumerableT
    {
        /// <summary>
        /// IEnumerble<T> contains a single method that you must implement when implementing this interface;
        /// GetEnumerator(), which returns an IEnumerator<T> provides the abilit to iterate through the collction by exposing a current property that points ath the object we are currently at in the collection.
        /// </summary>
        /// <param name="args"></param>
        
    }

    class Dog
    {
        //name of dog
        public string Name { get; set; }
        //is bad dog
        public bool IsBadDog { get; set; }
        //simple constructor
        public Dog (string name, bool isBadDog)
        {
            this.Name = name;
            this.IsBadDog = isBadDog;
        }
        //this methods will print how many treats the dog received
        public void GiveTreat(int numbersOfTreats)
        {

            //print a message containing the number of treats and the name of the dog
            Console.WriteLine($"Dog:{Name} said wuff {numbersOfTreats}");
        }
    }
    //a class named DogShelter this class contains a generic collection of type Dog
    //objects of this class can't be used inside a for each loop because it lack an implemenation of the Ineumerable interface
    class DogShelter:IEnumerable<Dog>
    {
        //list of type List<Dog>
        public List<Dog> dogs;
        //constructor will init dogs list with values
        public DogShelter()
        {
            //init dogs list using collection-init
            dogs = new List<Dog>()
            {
                new Dog("Casper",false),
                new Dog("Sif",true),
                new Dog("Oero",false),
                new Dog("Pixel",false),
            };
        }
        /// <summary>
        /// WHEN TO USE IENUMERABLE INTERFACE
        /// your collection represents a massive database table;
        /// you don't want to copy the entire thing into memory and cause performace issues in app;
        /// dont use when you need results right away and possibly mutating/editing the objects. 
        /// better to use array or a list;
        /// </summary>
        /// <returns></returns>
        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }
        //For nongeneric. must have
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
