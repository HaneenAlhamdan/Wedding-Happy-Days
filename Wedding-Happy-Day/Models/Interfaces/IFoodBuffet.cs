using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wedding_Happy_Day.Model.Interfaces
{
    public interface IFoodBuffet
    {
        Task<List<Food_buffet>> GetFoodBuffets();

        Task<Food_buffet> CreateFoodBuffet(Food_buffet FoodBuffet);

        Task<Food_buffet> GetFoodBuffet(int Id);

        Task<Food_buffet> UpdateFoodBuffet(int Id, Food_buffet FoodBuffet);

        Task DeleteFoodBuffet(int Id);
    }
}
