using System;

namespace ConsoleApp1
{
    class Student : User
    {
        private double scholarships;
        private int course;

        public Student(string name, int age, double scholarships, int course)
            : base(name, age)
        {
            this.scholarships = scholarships;
            this.course = course;
        }

        public double GetScholarships()
        {
            return scholarships;
        }

        public void SetScholarships(double scholarships)
        {
            if (scholarships < 0)
                throw new ArgumentException("Степендия должна быть выше, чем ноль!");

            this.scholarships = scholarships;
        }

        public double GetCourse()
        {
            return course;
        }

        public void SetCourse(int course)
        {
            if (course < 1)
                throw new ArgumentException("Курс должен быть выше, чем ноль!");

            this.course = course;
        }
    }
}
