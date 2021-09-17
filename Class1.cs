using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class ProgramStringManipulation
    {
        static void Main2(string[] args)
        {
            //defire few variabls
            int age = 31;
            string name = "Alfonso";

            // 1. string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old.");

            //2. String formatting.
            //string formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}. I am {1} years old", name, age);

            //3. String interpolation.
            // string Interpolation uses $ at the start which will allow us to write our variable like this {variablename}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old");

            //Verbatim strings.
            //verbatim strings start with @ and tells the compiler to take the string literally and ignore any spaces escape characters like \n
            Console.WriteLine("Verbatim string");
            Console.WriteLine(@"Lorem ip dol si me");

            string stringChallenge;
            Console.WriteLine("Please enter your name and press enter");
            stringChallenge = Console.ReadLine();
            Console.WriteLine(stringChallenge.ToUpper());
            Console.WriteLine(stringChallenge.ToLower());
            Console.WriteLine(stringChallenge.Trim());

            Console.WriteLine("Please enter a string");
            string searchTerm = Console.ReadLine();
            Console.WriteLine("Please enter a letter to search");
            char searchLetter = (char) Console.Read();
            Console.WriteLine("Index of searchLetter is {0}", searchTerm.IndexOf(searchLetter));
            





        }
    }
}
