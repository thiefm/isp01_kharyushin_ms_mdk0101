using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Worker worker01 = new Worker("Иван", 25, 1000);
            Worker worker02 = new Worker("Вася", 26, 2000);

            Console.WriteLine($"Сумма зарплат: {worker01.GetSalary() + worker02.GetSalary()}");
            Console.ReadKey();
        }
    }
}
