using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnum.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }
        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        public double SubTotal()
        {
            return Price * Quantity;
        }


        public override string ToString()
        {
            Order Order = new Order();

            StringBuilder sb = new StringBuilder();
            foreach (OrderItem order in Order.Items)
            {
                sb.AppendLine("Order items:\n");
                sb.AppendLine($"{order.Product.Name}, ");
                sb.AppendLine($"({order.Product.Price}), ");
                sb.AppendLine($"Quantity: {order.Quantity}, ");
                sb.AppendLine($"Subtotal: { order.SubTotal()}");
            }
            return sb.ToString();

        }

    }
}
