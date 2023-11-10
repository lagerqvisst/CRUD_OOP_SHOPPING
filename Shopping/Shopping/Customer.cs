using System;
namespace Shopping
{
    public class Customer
    {
        public string name;
        public string adress;
        public string email;
        public ShoppingCart cart;
        public string userName;

        public Customer(string name, string adress, string email, string userName)
        {
            this.name = name;
            this.adress = adress;
            this.email = email;
            this.userName = userName;

        }
    }
}

