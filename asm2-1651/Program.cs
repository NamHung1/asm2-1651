using asm2_1651.Builder;
using asm2_1651.Models;
using static asm2_1651.Builder.SneakerBuilder;

namespace asm2_1651
{
    class Program
    {
        public static List<Shoe> shoes = new List<Shoe>();
        static List<Customer> customers = new List<Customer>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Shoe Store!");

            while (true)
            {
                Console.Clear();

                Console.WriteLine("========================");
                Console.WriteLine("| 1. Build a Shoe      |");
                Console.WriteLine("| 2. Build a Customer  |");
                Console.WriteLine("| 3. Show all Shoes    |");
                Console.WriteLine("| 4. Show all Customer |");
                Console.WriteLine("| 5. Exit              |");
                Console.WriteLine("========================");
                Console.WriteLine("Choose an option:");
                int option = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (option)
                {
                    case 1:
                        CreateShoe();
                        break;
                    case 2:
                        CreateCustomer();
                        break;
                    case 3:
                        ShowAllShoes();
                        Console.ReadKey();
                        Console.Clear(); ;
                        break;
                    case 4:
                        ShowAllCustomers();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Exiting the program...");
                        return;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
            

        }

        static void CreateShoe()
        {
            Console.WriteLine("Creating a new shoe...");

            while(true)
            {
                Console.Clear();

                Console.WriteLine("=================");
                Console.WriteLine("| 1. Sneaker    |");
                Console.WriteLine("| 2. Loafer     |");
                Console.WriteLine("| 3. Chelsea    |");
                Console.WriteLine("| 4. Back       |");
                Console.WriteLine("=================");
                Console.WriteLine("Select an option: ");
                string shoeType = Console.ReadLine();

                Console.Clear();

                ShoeBuilder builder;
                Shoe shoe;

                switch (shoeType)
                {
                    case "1":
                        builder = new SneakerBuilder();
                        shoe = new Shoe();
                        builder.Build(shoe);
                        // shoes.Add(shoe);
                        // Console.WriteLine(shoe.ToString());
                        // Console.WriteLine("Sneaker created successfully!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        builder = new LoaferBuilder();
                        shoe = new Shoe();
                        builder.Build(shoe);
                        shoes.Add(shoe);
                        Console.WriteLine("Loafer created successfully!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        builder = new ChelseaBuilder();
                        shoe = new Shoe();
                        builder.Build(shoe);
                        shoes.Add(shoe);
                        Console.WriteLine("Chelsea created successfully!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.ReadKey();
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Invalid shoe type. Please try again.");
                        return;
                }
            }

        }

        static void CreateCustomer()
        {
            Console.WriteLine("Creating a new customer...");

            while (true)
            {
                Console.Clear();

                Console.WriteLine("======================");
                Console.WriteLine("| 1. VIP Customer    |");
                Console.WriteLine("| 2. Daily Customer  |");
                Console.WriteLine("| 3. Back            |");
                Console.WriteLine("======================");
                Console.WriteLine("Select an option:");
                string customerType = Console.ReadLine();

                Console.Clear();

                CustomerBuilder builder;
                Customer customer;

                switch (customerType)
                {
                    case "1":
                        builder = new VipCustomerBuilder();
                        customer = new Customer();
                        builder.Build(customer);
                        customers.Add(customer);
                        Console.WriteLine("VIP Customer created successfully!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        builder = new DailyCustomerBuilder();
                        customer = new Customer();
                        builder.Build(customer);
                        customers.Add(customer);
                        Console.WriteLine("Daily Customer created successfully!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.ReadKey();
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Invalid customer type. Please try again.");
                        return;
                }
            }
            
        }

        static void ShowAllCustomers()
        {
            Console.WriteLine("List of all customers:");

            if (customers.Count == 0)
            {
                Console.WriteLine("No customers found.");
            }
            else
            {
                foreach (Customer customer in customers)
                {
                    Console.WriteLine(customer.ToString());

                    Console.WriteLine("===========================");
                }
            }
        }

        static void ShowAllShoes()
        {
            Console.WriteLine("List of all shoes:");
            

            if (shoes.Count == 0)
            {
                Console.WriteLine("No shoes found.");
            }
            else
            {
                foreach (Shoe shoe in shoes)
                {
                    Console.WriteLine(shoe.GetType().Name);

                    Console.WriteLine(shoe.ToString());

                    Console.WriteLine("===========================");
                }
            }
        }
    }
}