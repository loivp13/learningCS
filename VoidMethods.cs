using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class VoidMethods
    {
        static void VoidMethods1(string[] args)
        {
            Add(14, 21);
            
        }
        //acess modifier | (static) | return type | method name | (parameter1, parameter2)
       /* public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomeThingSpecific(string myText)
        {
            Console.WriteLine(myText);
            Console.Read();
        }*/
       public static int Add( int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
