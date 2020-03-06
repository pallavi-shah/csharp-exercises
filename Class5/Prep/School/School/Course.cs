using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Course
    {
            public string name;
            public int courseCredit;
            public List<Student> students = new List<Student>();
            public Course(string aname, int aCourseCredit)
            {
                name = aname;
                courseCredit = aCourseCredit;
            }
    }
}
