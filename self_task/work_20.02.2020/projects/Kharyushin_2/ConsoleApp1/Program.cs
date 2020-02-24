using System;
using ConsoleApp1.Hierarchy_01;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Person[] persons = new Person[4]
            {
                new Student("Петров", 15, 1, "ИСП-1"),
                new Student("Иванов", 17, 2, "ИСП-2"),
                new Teacher("Лобанов", 67, new string[] { "Математика", "Химия" }),
                new Teacher("Казанов", 26, new string[] { "Программирование", "Информатика" })
            };

            foreach (Person elem in persons)
                Console.WriteLine(elem);

            Console.ReadKey();
        }
    }
}
