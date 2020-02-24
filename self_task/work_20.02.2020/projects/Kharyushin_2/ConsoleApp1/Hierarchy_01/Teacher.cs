using System;
using System.Collections.Generic;

namespace ConsoleApp1.Hierarchy_01
{
    class Teacher : Person
    {
        private List<string> disciplines;

        public Teacher(string name, int age, string[] disciplines)
            : base(name, age) 
        {
            if (disciplines != null)
                this.disciplines = new List<string>(disciplines);
        }

        public void AddDiscipline(string discipline)
        {
            if (discipline == null || discipline.Length < 1)
                return;

            disciplines.Add(discipline);
        }

        public void RemoveDiscipline(string discipline)
        {
            if (discipline == null || discipline.Length < 1)
                return;

            if (disciplines.Contains(discipline))
                disciplines.Remove(discipline);
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"{base.ToString()}; Дисциплины: {(disciplines != null ? string.Join(", ", disciplines) : "")}";
        }
    }
}
