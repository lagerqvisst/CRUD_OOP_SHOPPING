using System;
namespace Shopping
{
    public class Clothing : Product
    {
        public string size;
        public string type;

        public Clothing(string size, string type, string name, string description, double price)
            : base(name, description, price)
        {
        }
    }
}

