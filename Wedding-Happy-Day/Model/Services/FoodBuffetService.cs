using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wedding_Happy_Day.Model.Interfaces;

namespace Wedding_Happy_Day.Model.Services
{
    public class FoodBuffetService : IFoodBuffet
    {
        public Task<Food_buffet> CreateFoodBuffet(Food_buffet FoodBuffet)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFoodBuffet(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Food_buffet> GetFoodBuffet(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Food_buffet>> GetFoodBuffets()
        {
            throw new NotImplementedException();
        }

        public Task<Food_buffet> UpdateFoodBuffet(int Id, Food_buffet FoodBuffet)
        {
            throw new NotImplementedException();
        }
    }
}
