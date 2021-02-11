using EastWest.Domain.Core;
using EastWest.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EastWest.Infrastructure.Business
{
   public class OrderListFilter:IOrderFilter
    {
        public List<Order> ByCustomerName(List<Order> orders, string name)
        {
            if (!String.IsNullOrEmpty(name) && name!="all")
            {
                orders = orders.Where(p => p.Customer.Name.ToLower().Contains(name.ToLower())).ToList();
            }

            return orders;
        }

        public List<Order> ByDateTime(List<Order> orders, DateTime dateTime)
        {

            if (dateTime != null && dateTime !=DateTime.MinValue)
            {
                orders = orders.Where(p => p.DateTime == dateTime).ToList();
            }

            return orders;
        }
    }
}
