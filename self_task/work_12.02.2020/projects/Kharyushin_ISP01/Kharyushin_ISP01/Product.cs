namespace Kharyushin_ISP01
{
    class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string ShelfLife { get; set; }

        public Product(string name, int quantity, double price, string shelflife)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            ShelfLife = shelflife;
        }

        public override string ToString()
        {
            return $"Имя: {Name}; Количество: {Quantity}; Цена: {Price}; Срок годности: {ShelfLife}";
        }
    }
}
