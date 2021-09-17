using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class Member
    {
        //member - private field
        private string memberName;
        private string jobTitle;
        private int salary = 20000;

        //member - public field
        public int age;

        // memeber - property - exposes jobTitle safely - propteries start with a capital letter
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }

        }
        //public member methods - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }

        }
        //private memeber methods 
        private void SharingPrivateInfo()
        {
            Console.WriteLine("My Salary is {0}, and my job title is {1}. I'm {2} years old", salary,jobTitle,age);
        }
        //member constructor
        public Member()
        {
            age = 30;
            memberName = "Lucy";
            jobTitle = "Developer";

            Console.WriteLine("Object created");
        }

        //memever - finalizer = destructor
        ~Member()
        {
            //cleanup statements
            Console.WriteLine("Deconstruction of Members objects");
        }
    }
}
