using System;
using System.Collections.Generic;

namespace ConsoleApp1.Hierarchy_01
{
    class Student : Person
    {
        private string group;
        private int course;

        public Student(string name, int age, int course, string group)
            : base(name, age)
        {
            this.course = course;
            this.group = group;
        }

        public void NextCourse()
        {
            course++;
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Группа: {group}; Курс: {course}";
        }
    }
}
