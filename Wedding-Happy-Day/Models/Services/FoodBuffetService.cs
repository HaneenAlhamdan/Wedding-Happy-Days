using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wedding_Happy_Day.Data;
using Wedding_Happy_Day.Model.Interfaces;

namespace Wedding_Happy_Day.Model.Services
{
    public class FoodBuffetService : IFoodBuffet
    {
        private DataBaseContext _context;

        public FoodBuffetService(DataBaseContext context)
        {
            _context = context;

        }
        public async Task<Food_buffet> CreateFoodBuffet(Food_buffet FoodBuffet)
        {
            Food_buffet NewFoodBuffet = new Food_buffet
            {
                Id = FoodBuffet.Id,
                Name = FoodBuffet.Name,
                Email = FoodBuffet.Email,
                Phone = FoodBuffet.Phone,
                Price = FoodBuffet.Price,
                Address = FoodBuffet.Address,
                Description = FoodBuffet.Description,
                Logo = FoodBuffet.Logo,

            };
            _context.Entry(FoodBuffet).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return NewFoodBuffet;
        }

        public async Task DeleteFoodBuffet(int Id)
        {
            Food_buffet FoodBuffet = await _context.Food_buffets.FindAsync(Id);
            _context.Entry(FoodBuffet).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<Food_buffet> GetFoodBuffet(int Id)
        {
            var FoodBuffetDetails = await _context.Food_buffets
                .Include(c => c.Wedding)

                              .FirstOrDefaultAsync(n => n.Id == Id);

            return FoodBuffetDetails;
        }

        public async Task<List<Food_buffet>> GetFoodBuffets()
        {
            return await _context.Car_rentals.Include(x => x.Wedding).Select(FoodBuffet => new Food_buffet
            {
                Id = FoodBuffet.Id,
                Name = FoodBuffet.Name,
                Email = FoodBuffet.Email,
                Phone = FoodBuffet.Phone,
                Price = FoodBuffet.Price,
                Address = FoodBuffet.Address,
                Description = FoodBuffet.Description,
                Logo = FoodBuffet.Logo,

            }).ToListAsync();
        }

        public async Task<Food_buffet> UpdateFoodBuffet(int Id, Food_buffet FoodBuffet)
        {
            Food_buffet UpdateFoodBuffet = new Food_buffet
            {
                Id = FoodBuffet.Id,
                Name = FoodBuffet.Name,
                Email = FoodBuffet.Email,
                Phone = FoodBuffet.Phone,
                Price = FoodBuffet.Price,
                Address = FoodBuffet.Address,
                Description = FoodBuffet.Description,
                Logo = FoodBuffet.Logo,
            };
            _context.Entry(FoodBuffet).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return UpdateFoodBuffet;
        }
    }
}
