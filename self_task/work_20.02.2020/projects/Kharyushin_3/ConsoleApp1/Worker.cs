using System;

namespace ConsoleApp1
{
    class Worker : User
    {
        private double salary;

        public Worker(string name, int age, double salary)
            : base(name, age)
        {
            this.salary = salary;
        }

        public void SetSalary(double salary)
        {
            if (salary < 0)
                throw new ArgumentException("Зарплата должна быть выше, чем ноль!");

            this.salary = salary;
        }

        public double GetSalary()
        {
            return salary;
        }
    }
}
