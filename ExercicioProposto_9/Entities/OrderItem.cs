using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioProposto_9.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantidade, double price, Product product)
        {
            Quantity = quantidade;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            double sub = Quantity * Price;
            return sub;
        }
    }
}
