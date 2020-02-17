namespace Kharyushin_ISP01
{
    class Group
    {
        public string Cipher { get; set; }
        public int Quantity { get; set; }
        public int YearOfFormation { get; set; }
        public string Specialty { get; set; }

        public Group(string cipher, int quntity, int yearformation, string specialty)
        {
            Cipher = cipher;
            Quantity = quntity;
            YearOfFormation = yearformation;
            Specialty = specialty;
        }

        public override string ToString()
        {
            return $"Шифр: {Cipher}; Количество: {Quantity}; Год формирования: {YearOfFormation}; Специальность: {Specialty}";
        }
    }
}
