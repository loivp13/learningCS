using System;

namespace LearningVisualStudioC
{
    class Program
    {
        static void Main1(string[] args)
        {
            //implicit conversion
            int num = 123898327;
            long bigNum = num;

            //explicit (casting)
            double myDouble = 13.37;
            int myInt;
            myInt = (int)myDouble;
            Console.WriteLine(myInt);
            Console.Read();

            //typeConversion
            string myString = myDouble.ToString();
            num.ToString();


            //Parsing
            string stringNum1 = "15";
            string stringNum2 = "20";
            int num1 = Int32.Parse(stringNum1);
            int num2 = int.Parse(stringNum2);
            Console.WriteLine(num2 + num1);


        }
    }
}
