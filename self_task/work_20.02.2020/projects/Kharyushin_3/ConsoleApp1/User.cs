using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class User
    {
        protected string name;
        protected int age;

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void SetName(string name)
        {
            if (name == null || name.Length < 1)
                throw new ArgumentException("Имя должно быть больше одного символа!");

            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetAge(int age)
        {
            if (age < 1)
                throw new ArgumentException("Возраст должен быть больше 1 года!");

            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }
    }
}
