using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wedding_Happy_Day.Model.Interfaces
{
    public interface IOrder
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId, string userRole);
    }
}
