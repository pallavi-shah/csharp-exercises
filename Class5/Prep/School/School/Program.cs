using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Course Eng = new Course("english",39);
            Course Math = new Course("math",40);
            Course Comp = new Course("computers",70);
            Student Student1 = new Student("Chetan");
            Student Student2 = new Student("Pallavi");
            Student1.AddGrade(Eng, 3);
            Console.WriteLine("gpa of {0} : {1} ", Student1.Name, Student1.Gpa);
            Student1.AddGrade(Comp, 2);
            Student2.AddGrade(Math, 3);
            Console.WriteLine("gpa of {0} : {1} ", Student1.Name,Student1.Gpa);
            Console.WriteLine("GPA of student {0}, ID {1} is {2}", Student1.Name, Student1.StudentId, Student1.Gpa);
            Console.WriteLine("GPA of student {0}, ID {1} is {2}", Student2.Name,Student2.StudentId, Student2.Gpa);
            Console.WriteLine("NumberOfCredits of {0} : {1}", Student1.Name, Student1.NumberOfCredits);
            Console.WriteLine("GradeLevel of {0} : {1}", Student1.Name, Student1.GetGradeLevel());
            Console.WriteLine(Student1.ToString());
            Console.WriteLine(Student1.Equals(Student2)); 
            Console.ReadLine();
        }
    }
}
