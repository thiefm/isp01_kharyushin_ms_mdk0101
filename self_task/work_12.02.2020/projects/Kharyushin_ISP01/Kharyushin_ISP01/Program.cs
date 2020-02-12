using System;

namespace Kharyushin_ISP01
{
    class Program
    {
        static void Main()
        {
            Student student = new Student("Иванов", 2, "Мужской");
            Console.WriteLine(student.ToString());

            Employee employee = new Employee("Иванов", "ИСП-1", 3);
            Console.WriteLine(employee.ToString());

            Shop shop = new Shop("ЛФ", 150);
            Console.WriteLine(shop.ToString());

            Book book = new Book("C#", new string[] { "Троелсан", "Котов" }, 5000);
            Console.WriteLine(book.ToString());

            Test test = new Test("Харитонов А.О.", "Иванова О.В.", "01.01.2020", 5);
            Console.WriteLine(test.ToString());

            Address address = new Address(443101, "Волжский", "Дружбы", "189", 13);
            Console.WriteLine(address.ToString());

            Product product = new Product("Книга", 15, 3000, "Отсутствует");
            Console.WriteLine(product.ToString());

            Group group = new Group("ИСП", 20, 2018, "ИСП-1");
            Console.WriteLine(group.ToString());

            Banknote banknote = new Banknote(303, 5, "Пять рублей");
            Console.WriteLine(banknote.ToString());

            Game game = new Game("CS:GO", "Valve", "2008", "Шутер");
            Console.WriteLine(game.ToString());

            Console.ReadKey();
        }
    }
}