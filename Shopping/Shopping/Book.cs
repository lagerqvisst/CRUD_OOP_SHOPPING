using System;
using System.Xml.Linq;

namespace Shopping
{
    public class Book : Product
    {
        public string author;
        public int pages;
        public string genre;

        public Book(string author, int pages, string genre, string name, double price, string description)
            : base(name, description, price)
        {
            this.author = author;
            this.pages = pages;
            this.genre = genre;
        }
    }
}

