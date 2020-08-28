using ExercicioProposto_9.Entities.Enums;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProposto_9.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(DateTime date, OrderStatus status, Client client)
        {
            Date = date;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem order)
        {
            Itens.Add(order);
        }

        public void RemoveItem(OrderItem order)
        {
            Itens.Remove(order);
        }

        public double Total()
        {
            double total = 0;
            foreach (OrderItem order in Itens)
            {
                total += order.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items: ");
            foreach (OrderItem order in Itens)
            {
                sb.AppendLine(order.ToString());
            }
            sb.AppendLine("Total price: " + Total().ToString("F2"));

            return sb.ToString();
        }




    }
}
