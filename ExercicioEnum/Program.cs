using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioEnum.Entities;
using ExercicioEnum.Entities.Enums;
using System.Globalization;

namespace ExercicioEnum
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            /* string birthDate = Console.ReadLine();
             int day = int.Parse( birthDate.Substring(0, 2));
             int month = int.Parse( birthDate.Substring(3,2));
             int year = int.Parse(birthDate.Substring(5));
             */
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            string status = Console.ReadLine();

            Enum.TryParse(status, true, out OrderStatus orderStatus);

            Console.Write("How many items to this order? ");
            int N = int.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);


            //Product product = new Product();


            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");

                Console.Write("Product name: ");
                string pName = Console.ReadLine();

                Console.Write("Product price: ");
                double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int qtd = int.Parse(Console.ReadLine());

                Product product = new Product(pName, pPrice);
                OrderItem orderItem = new OrderItem(qtd, pPrice, product);
                Order order = new Order(DateTime.Now, orderStatus, client);
                order.Items.Add(orderItem);



            }


            StringBuilder sb = new StringBuilder();
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            sb.AppendLine(order.ToString());
            sb.AppendLine(client.ToString());
            sb.AppendLine(orderItem.ToString());
            sb.AppendLine(order.Total().ToString());
            Console.WriteLine(sb.ToString());

        }
    }
}
