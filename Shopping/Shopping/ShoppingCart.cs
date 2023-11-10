using System;
namespace Shopping
{
    public class ShoppingCart
    {
        private List<Product> items;

        public ShoppingCart()
        {
            items = new List<Product>();
        }
        public void AddItemToCart(Product item)
        {
            items.Add(item);
            Console.WriteLine($"{item.name} has been added from the cart");
        }
        public void RemoveItemFromCart(Product item)
        {
            items.Remove(item);
            Console.WriteLine($"{item.name} has been removed from the cart");
        }
        public void ClearCart()
        {
            foreach (Product item in items)
            {
                items.Remove(item);
            }
            Console.WriteLine("Shopping cart has been cleared");
        }
        public void ViewItems()
        {

            foreach (Product item in items)
            {
                Console.WriteLine("{0} - {1:C}", item.name, item.price);

            }
        }
        public void CheckOut()
        {
            ViewItems();
            Console.WriteLine("---------------");
            double totalPrice = 0;
            foreach (Product item in items)
            {

                totalPrice += item.price;
            }

            Console.WriteLine("Your total is {0:C}", totalPrice);
        }
    }
}

