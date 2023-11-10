using System;
namespace Shopping
{
    public class Store
    {
        public List<Product> inventory;
        public List<Customer> customers;

        public Store()
        {
            inventory = new List<Product>();
            customers = new List<Customer>();
        }
        public void AddToInventory(Product product)
        {
            inventory.Add(product);
            Console.WriteLine($"{product} has been added to the store");
        }
        public void RemoveFromInventory(Product product)
        {
            inventory.Remove(product);
            Console.WriteLine($"{product} has been removed to the store");
        }
        public void ViewInventory()
        {
            foreach (Product item in inventory)
            {
                Console.WriteLine($"{item.name} - {item.description} - {item.price}\n");
            }
        }
        public void SearchForItem(string search)
        {
            int results = 0;
            Console.WriteLine("Search for product: ");
            search = Console.ReadLine();

            foreach (Product item in inventory)
            {
                if (search.Contains(item.name) && search.Contains(item.description))
                {
                    Console.WriteLine($"{item.name} - {item.description} - {item.price}");
                    results++;
                }
            }
            Console.WriteLine($"{results} results were found.");
        }
    }
}

