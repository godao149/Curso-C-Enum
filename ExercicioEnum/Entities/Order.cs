using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioEnum.Entities.Enums;

namespace ExercicioEnum.Entities
{
    class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }

        public Client Client { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }
        //public Order(DateTime moment, OrderStatus status) {
        //    Moment = moment;
        //    Status = status;
        //}

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }



        public void AddItem(OrderItem item)
        {
            Items.Add(item);

        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum = item.SubTotal();
            }
            return sum;
        }


        public override string ToString()
        {
            return $"Order moment: {Moment}\nOrder status: {Status}";
        }
    }

}
