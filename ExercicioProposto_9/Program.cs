using ExercicioProposto_9.Entities;
using ExercicioProposto_9.Entities.Enums;
using System;

namespace ExercicioProposto_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            DateTime date = DateTime.Now;
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birth);
            Order order = new Order(date, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            
                for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string pname = Console.ReadLine();
                Console.Write("Product price: ");
                double pprice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int pquantity = int.Parse(Console.ReadLine());
                Product product = new Product(pname, pprice);
                OrderItem item = new OrderItem(pquantity, pprice, product);
                order.AddItem(item);
            }

            Console.WriteLine(order);

        }
    }
}
