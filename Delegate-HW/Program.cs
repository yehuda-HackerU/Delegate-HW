using System;

namespace Delegate_HW
{
    class Program
    {
        #region Ex1
        public static void Func1()
        {
            Console.WriteLine("Hello from Func1!");
        }

        public static void Func2()
        {
            Console.WriteLine("Hello from Func2!");
        }
        #endregion

        static void Main(string[] args)
        {
            #region Ex1
            MyDelegate myFirstDelegate1 = new MyDelegate(Func1);
            myFirstDelegate1();
            MyDelegate myFirstDelegate2 = new MyDelegate(Func2);
            myFirstDelegate2();
            #endregion

            #region Ex2
            Student student = new Student();
            student.FirstName = "Yehuda";
            var greet1 = new Greet(student.Greet1);
            var greet2 = new Greet(student.Greet2);
            greet1(student.FirstName);
            greet2(student.FirstName);
            #endregion

            #region Ex3
            //Func1 dosn't have the same signature as Greet require.
            //var greetTest = new Greet(Func1);
            #endregion

            #region ???
            Student s1 = new Student("yehuda", "ben-shushan", 26);
            StudentsList.Add(s1);
            StudentsList.Add("yair", "ben-shushan", 3);
            StudentsList.Add("John", "Doe", 18);
            //StudentsList.Remove("yair", "ben-shushan");
            //var res = StudentsList.AgeFilter(17, true);
            foreach (var item in StudentsList.Students)
            {
                Console.WriteLine(item);
            }

            #endregion



            Console.WriteLine("\n\nPress any key to close...");
            Console.ReadKey();
        }
    }
}
