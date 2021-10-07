using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_HW
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void Greet1(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        public void Greet2(string name)
        {
            Console.WriteLine($"Welcome {name}!");
        }

        public Student()
        {

        }

        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return $"Student {FirstName} {LastName}.";
        }
    }
}
