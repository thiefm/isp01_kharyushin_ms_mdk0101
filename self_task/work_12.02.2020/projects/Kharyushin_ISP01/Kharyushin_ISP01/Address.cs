using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kharyushin_ISP01
{
    class Address
    {
        public int PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public int Flat { get; set; }

        public Address(int postalcode, string city, string street, string house, int flat)
        {
            PostalCode = postalcode;
            City = city;
            Street = street;
            House = house;
            Flat = flat;
        }

        public override string ToString()
        {
            return $"Почтовый индекс: {PostalCode}; Город: {City}; Улица: {Street}; Дом: {House}; Квартира: {Flat}";
        }
    }
}
