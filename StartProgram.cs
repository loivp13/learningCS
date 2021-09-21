using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningVisualStudioC
{
    class StartProgram
    {
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student[] studentsArr = new Student[5];

            studentsArr[0] = new Student(1, "Dennis", 88);
            studentsArr[1] = new Student(2, "Olaf", 97);
            studentsArr[2] = new Student(6, "Ragner", 65);
            studentsArr[3] = new Student(1, "Luise", 73);
            studentsArr[4] = new Student(4, "Levi", 58);

            foreach (Student entry in studentsArr)
            {
                if (studentsTable.ContainsKey(entry.Id))
                {
                    Console.WriteLine("Student id: {0}, student {1} is repeated",entry.Id, entry.Name);
                }else
                {
                    studentsTable.Add(entry.Id,entry);
                }
            }

            foreach (PropertyDescriptor discriptor in TypeDescriptor.GetProperties(studentsTable))
            {
                string name = discriptor.Name;
                object value = discriptor.GetValue(studentsTable);
                Console.WriteLine("{0}={1}", name, value);
            }
        }
        static void Main1(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Lucy", 65);
            Student stud3 = new Student(3, "James", 99);
            Student stud4 = new Student(4, "Steve", 55);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);

            Student storedStudent1 = (Student)studentsTable[1];
            Console.WriteLine("{0} {1} {2}", storedStudent1.Id, storedStudent1.GPA, storedStudent1.Name);

            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("{0}", temp.Id);
                Console.WriteLine("{0}", temp.Name);
                Console.WriteLine("{0}", temp.GPA);
            }

            foreach (Student value in studentsTable.Values)
            {
                Console.WriteLine("{0}", value.Id);
                Console.WriteLine("{0}", value.Name);
                Console.WriteLine("{0}", value.GPA);
            }
        }
        
    }
}
 