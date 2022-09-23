using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wedding_Happy_Day.Model.Interfaces;

namespace Wedding_Happy_Day.Model.Services
{
    public class OrdersService : IOrder
    {
        public Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole)
        {
            throw new NotImplementedException();
        }

        public Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress)
        {
            throw new NotImplementedException();
        }
    }
}
