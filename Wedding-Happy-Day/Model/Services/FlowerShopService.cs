using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wedding_Happy_Day.Model.Interfaces;

namespace Wedding_Happy_Day.Model.Services
{
    public class FlowerShopService : IFlowerShop
    {
        public Task<Flower_Shop> CreateFlowerShop(Flower_Shop FlowerShop)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFlowerShop(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Flower_Shop> GetFlowerShop(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Flower_Shop>> GetFlowerShops()
        {
            throw new NotImplementedException();
        }

        public Task<Flower_Shop> UpdateFlowerShop(int Id, Flower_Shop FlowerShop)
        {
            throw new NotImplementedException();
        }
    }
}
