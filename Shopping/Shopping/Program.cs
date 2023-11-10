namespace Shopping
{
    class Program
    {
        static Store store = new Store();
        static Customer currentUser;

        static void Main(string[] args)
        {
            FyllData();
            bool signedIn = false;

            while (!signedIn)
            {
                HuvudMeny();
                int menyVal = int.Parse(Console.ReadLine());

                if (menyVal == 1)
                {
                    SignIn();
                    if (currentUser != null)
                    {
                        signedIn = true;
                    }
                }
                else if (menyVal == 2)
                {
                    break;
                }

            }
            while (signedIn)
            {
                CustomerMenu();
                int menyVal = int.Parse(Console.ReadLine());

                if (menyVal == 1)
                {
                    store.ViewInventory();
                }
                else if (menyVal == 2)
                {
                    Console.Write("Enter item you wish to add to cart: ");
                    string select = Console.ReadLine();

                    Product addProduct = store.inventory.FirstOrDefault(p => p.name == select);
                    if (addProduct != null)
                    {
                        if (currentUser.cart == null)
                        {
                            currentUser.cart = new ShoppingCart();
                        }
                        currentUser.cart.AddItemToCart(addProduct);

                    }
                    else
                    {
                        Console.WriteLine($"{select} was not found in the store inventory");
                    }

                }
                else if (menyVal == 3)
                {
                    currentUser.cart.ViewItems();

                }
                else if (menyVal == 4)
                {
                    Console.Write("Enter item you wish to remove to cart: ");
                    string select = Console.ReadLine();

                    Product removeProduct = store.inventory.FirstOrDefault(p => p.name == select);
                    if (removeProduct != null)
                    {
                        currentUser.cart.AddItemToCart(removeProduct);

                    }
                    else
                    {
                        Console.WriteLine($"{select} was not found in your cart");
                    }
                }
                else if (menyVal == 5)
                {
                    currentUser.cart.CheckOut();
                }
                else if (menyVal == 6)
                {
                    signedIn = false;

                }
            }


        }
        static void FyllData()
        {

            Customer user1 = new Customer("Alexander Lagerqvist", "Fjärde Långgatan 6B", "alexander.lagerqvist@hotmail.com", "alex123");
            Customer user2 = new Customer("Malin Velander", "Fjärde Långgatan 6B", "malin.evelander@gmail.com", "juno1");
            store.customers.Add(user1);
            store.customers.Add(user2);

            Book book1 = new Book("Dan Brown", 500, "Mystery", "The DaVinci Code", 199, "Mysterious book about things");
            Book book2 = new Book("Astrid Lindgren", 420, "Children", "Emil i Lönneberga", 150, "Children book about Emil");
            store.inventory.Add(book1);
            store.inventory.Add(book2);

            Clothing c1 = new Clothing("L", "T-SHIRT", "GUCCI SHIRT", "Limited Edition Milan", 1500);
            Clothing c2 = new Clothing("M", "JEANS", "ARKET JEANS", "Skinny", 399);
            Clothing c3 = new Clothing("S", "JACKET", "CAT JACKET", "Jacket with Cat on", 399);
            store.inventory.Add(c1);
            store.inventory.Add(c2);

            Electronics e1 = new Electronics("Phone", "100GB", "", "iPhone Pro Max 14", "", 899);
            Electronics e2 = new Electronics("Gaming Station", "200GB", "", "PS5", "", 1299);
            Electronics e3 = new Electronics("TV", "", "65", "SamsungTV", "Samsung Smart TV OLED", 1599);
            store.inventory.Add(e1);
            store.inventory.Add(e2);
        }
        static void HuvudMeny()
        {
            Console.WriteLine("Welcome to E-STORE");
            Console.WriteLine("1 - Sign in.");
            Console.WriteLine("2 - Quit.");
        }
        static void SignIn()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Customer user = store.customers.FirstOrDefault(u => u.userName == username);

            if (user != null)
            {
                currentUser = user;
                Console.WriteLine($"Welcome back, {user.name}!");

            }
            else
            {
                Console.WriteLine("Sorry, we could not find a user with that username.");
            }
        }
        static void CustomerMenu()
        {
            Console.WriteLine("STORE");
            Console.WriteLine("1 - Browse store items");
            Console.WriteLine("2 - Add item to cart");
            Console.WriteLine("3 - View contents of shopping cart");
            Console.WriteLine("4 - Remove items");
            Console.WriteLine("5 - Check out");
            Console.WriteLine("6 - Sign out");
        }
    }
}

