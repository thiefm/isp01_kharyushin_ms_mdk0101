using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kharyushin_ISP01
{
    class Game
    {
        public string Name { get; set; }
        public string Firm { get; set; }
        public string PublicationDate { get; set; }
        public string Genre { get; set; }

        public Game(string name, string firm, string publdate, string genre)
        {
            Name = name;
            Firm = firm;
            PublicationDate = publdate;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"Имя: {Name}; Фирма: {Firm}; Год издания: {PublicationDate}; Жанр: {Genre}";
        }
    }
}
