using System;

namespace ConsoleApp1.Hierarchy_01
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void SetName(string name)
        {
            if (name == null || name.Length < 1)
                return;

            this.name = name;
        }

        public void SetAge(int age)
        {
            if (age < 1)
                return;

            this.age = age;
        }

        public virtual void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Имя: {name}; Возраст: {age}";
        }
    }
}
