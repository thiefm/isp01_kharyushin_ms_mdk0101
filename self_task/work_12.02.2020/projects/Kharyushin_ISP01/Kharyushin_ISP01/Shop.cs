namespace Kharyushin_ISP01
{
    class Shop
    {
        public string Cipher { get; set; }
        public int Quantity { get; set; }

        public Shop(string cipher, int quantity)
        {
            Cipher = cipher;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Строковой шифр: {Cipher}; Количество служащий: {Quantity}";
        }
    }
}
