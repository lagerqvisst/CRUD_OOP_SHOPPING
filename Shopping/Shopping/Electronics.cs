using System;
namespace Shopping
{
    public class Electronics : Product
    {
        public string type;
        public string storage;
        public string size;

        public Electronics(string type, string storage, string size, string name, string description, double price)
            : base(name, description, price)
        {
            this.type = type;
            this.storage = storage;
            this.size = size;
        }
    }
}

