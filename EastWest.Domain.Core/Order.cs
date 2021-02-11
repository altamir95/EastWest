using System;
using System.Collections.Generic;

namespace EastWest.Domain.Core
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime DateTime { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public List<OrderedProduct> OrderedProducts { get; set; }
        public Order()
        {
            OrderedProducts = new List<OrderedProduct>();
        }
    }
}
