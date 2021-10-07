using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_HW
{
    static class StudentsList
    {
        public static List<Student> Students { get; set; } = new List<Student>();

        public static void Add(Student student)
        {
            Students.Add(student);
        }
        public static void Add(string firstName, string lastName, int age)
        {
            Students.Add(new Student(firstName, lastName, age));
        }
        public static void Remove(Student student)
        {
            Students.Remove(student);
        }
        public static void Remove(string firstName, string lastName)
        {
            Students.Remove(Students.Find(x => x.FirstName == firstName && x.LastName == lastName));
        }

        public static List<Student> Filter(StudentFilter filter)
        {
            List<Student> result = new List<Student>();
            foreach (Student student in Students)
            {
                if (filter)
            }
        }

        #region concept filter
        public static List<Student> AgeFilter(int age, bool above)
        {
            List<Student> resulet = new List<Student>();
            if (above)
            {
                foreach (Student student in Students)
                {
                    if (student.Age > age)
                    {
                        resulet.Add(student);
                    }
                }
            }
            else
            {
                foreach (Student student in Students)
                {
                    if (student.Age < age)
                    {
                        resulet.Add(student);
                    }
                }
            }
            return resulet;
        }
        #endregion

    }
}
