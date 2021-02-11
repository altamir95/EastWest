using EastWest.Domain.Core;
using System.Collections.Generic;

namespace EastWest.Domain.Interfaces
{
   public interface IOrderRepository
    {
        List<Order> GetOrderList();
        Order GetOrder(int id);
        void Save();
    }
}
