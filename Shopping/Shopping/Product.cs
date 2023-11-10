using System;
namespace Shopping
{
    public class Product
    {
        public string name;
        public string description;
        public double price;

        public Product(string name, string description, double price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
}

