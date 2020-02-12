using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kharyushin_ISP01
{
    class Book
    {
        public string Name { get; set; }
        public string[] Authors { get; set; }
        public int Price { get; set; }

        public Book(string name, string[] authors, int price)
        {
            Name = name;
            Authors = authors;
            Price = price;
        }

        public override string ToString()
        {
            return $"Название: {Name}; Авторы: {(Authors != null ? string.Join(", ", Authors) : "")}; Цена: {Price}";
        }
    }
}
