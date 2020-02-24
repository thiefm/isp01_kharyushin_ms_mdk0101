using System;

namespace ConsoleApp1.Hierarchy_03
{
    class Employee
    {
        private static int counter = 0;
        private int id;
        private string name;

        public Employee(string name)
        {
            id = counter;
            counter++;
            this.name = name;
        }

        public override string ToString()
        {
            return $"ID: {id}; Имя: {name}";
        }
    }
}
