using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class DictionariesDemo
    {
        static void MainDictionary(string[] args)
        {
            Employee[] employees =
            {
                new Employee("CEO", "Gwyn", 95,200),
                new Employee("Manger", "Joe", 35,25),
                new Employee("HR", "Lora", 32,21),
                new Employee("Secretary", "Petra", 28,18),
                new Employee("Lead Developer", "Artorias", 55,35),
                new Employee("Intern", "Gwyn", 22,8),
            };

            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1,"one" },
                {2,"two" },
                {3,"three" }
            };

            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            //adding to directory(dictionary)
            foreach (Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp); 
            }

            Employee emp1 = employeesDirectory["CEO"];
            Console.WriteLine("{0}{1}", emp1.Role,emp1.Name);

            //TRYGETVALUE
            Employee result = null;
            if(employeesDirectory.TryGetValue("Intern", out result))
            {
                //result will be in result
            }else
            {
                Console.WriteLine("Key doesn't not exist");
            }

            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                //gets the key value pair at a numbered index;
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);
                Console.WriteLine("Key: {0}", keyValuePair.Key);
                Employee employeeValue = keyValuePair.Value; 
            }


            //UPDATE DICTIONARIES
            string KeyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(KeyToUpdate))
            {
                employeesDirectory[KeyToUpdate] = new Employee("HR", "Eleka", 26, 18);
            }

            //REMOVE FROM DICTIONARIES
            string KeyToRemove = "Intern";
            if (employeesDirectory.Remove(KeyToRemove))
            {
                //removed
            }else
            {
                //not found
            }

        }
    }

    class Employee
    {
        //few properties like Role, Name, age and Rate
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float  Rate { get; set; }
        public float Salary
        {
            get
            {
                return Rate * 9 * 5 * 4 * 12;
            }
        }

        public Employee(string role,string name,int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate; 
        }


    }


}
