using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Student
    {
        public static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public double TotalQualityScore { get; set; }


        public Student(string aname, int anumberOfCredits, double aGpa)
        {
            Name = aname;
            StudentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = anumberOfCredits;
            Gpa = aGpa;
        }

        public Student(string aname)
        {
            Name = aname;
            StudentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;

        }

        public void AddGrade(Course c1, int pointsRecd)
        {
            TotalQualityScore = Gpa * NumberOfCredits;
            double NewQualityScore = c1.courseCredit * pointsRecd;
            double UpdatedQualityScore = TotalQualityScore + NewQualityScore;
            NumberOfCredits = NumberOfCredits + c1.courseCredit;
            Gpa = UpdatedQualityScore / NumberOfCredits;
            Gpa = Math.Round(Gpa, 1);
        }

        public string GetGradeLevel()
        {
            if (NumberOfCredits <= 29)
            {
                return "freshman";
            }
            else if (NumberOfCredits >= 30 && NumberOfCredits <= 59)
            {
                return "sophomore";
            }
            else if (NumberOfCredits >= 60 && NumberOfCredits <= 89)
            {
                return "junior";
            }
            else
                return "senior";
        }

        public override string ToString()
        {
            return Name + " GPA: " + Gpa;
        }

        public override bool Equals(Object obj)
        {
            if (((Student)obj).Name == this.Name)
            {
                return true;
            }
            else
                return false;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}
