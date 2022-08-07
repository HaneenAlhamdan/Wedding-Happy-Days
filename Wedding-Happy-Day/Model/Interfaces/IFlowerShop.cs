using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wedding_Happy_Day.Model.Interfaces
{
    public interface IFlowerShop
    {
        Task<List<Flower_Shop>> GetFlowerShops();

        Task<Flower_Shop> CreateFlowerShop(Flower_Shop FlowerShop);

        Task<Flower_Shop> GetFlowerShop(int Id);

        Task<Flower_Shop> UpdateFlowerShop(int Id, Flower_Shop FlowerShop);

        Task DeleteFlowerShop(int Id);
    }
}

