using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wedding_Happy_Day.Data;
using Wedding_Happy_Day.Model.Interfaces;

namespace Wedding_Happy_Day.Model.Services
{
    public class FlowerShopService : IFlowerShop
    {
        private DataBaseContext _context;

        public FlowerShopService(DataBaseContext context)
        {
            _context = context;

        }
        public async Task<Flower_Shop> CreateFlowerShop(Flower_Shop FlowerShop)
        {
            Flower_Shop NewFlowerShop = new Flower_Shop
            {
                Id = FlowerShop.Id,
                Name = FlowerShop.Name,
                Email = FlowerShop.Email,
                Phone = FlowerShop.Phone,
                Price = FlowerShop.Price,
                Address = FlowerShop.Address,
                Description = FlowerShop.Description,
                Logo = FlowerShop.Logo,

            };
            _context.Entry(FlowerShop).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return NewFlowerShop;
        }

        public async Task DeleteFlowerShop(int Id)
        {
            Flower_Shop FlowerShop = await _context.Flower_Shops.FindAsync(Id);
            _context.Entry(FlowerShop).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<Flower_Shop> GetFlowerShop(int Id)
        {
            var FlowerShopDetails = await _context.Flower_Shops
                .Include(c => c.Wedding)

                              .FirstOrDefaultAsync(n => n.Id == Id);

            return FlowerShopDetails;
        }

        public async Task<List<Flower_Shop>> GetFlowerShops()
        {
            return await _context.Car_rentals.Include(x => x.Wedding).Select(FlowerShop => new Flower_Shop
            {
                Id = FlowerShop.Id,
                Name = FlowerShop.Name,
                Email = FlowerShop.Email,
                Phone = FlowerShop.Phone,
                Price = FlowerShop.Price,
                Address = FlowerShop.Address,
                Description = FlowerShop.Description,
                Logo = FlowerShop.Logo,

            }).ToListAsync();
        }

        public async Task<Flower_Shop> UpdateFlowerShop(int Id, Flower_Shop FlowerShop)
        {
            Flower_Shop UpdateFlowerShop = new Flower_Shop
            {
                Id = FlowerShop.Id,
                Name = FlowerShop.Name,
                Email = FlowerShop.Email,
                Phone = FlowerShop.Phone,
                Price = FlowerShop.Price,
                Address = FlowerShop.Address,
                Description = FlowerShop.Description,
                Logo = FlowerShop.Logo,
            };
            _context.Entry(FlowerShop).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return FlowerShop;
        }
    }
}
