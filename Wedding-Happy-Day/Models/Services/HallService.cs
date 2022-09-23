using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wedding_Happy_Day.Data;
using Wedding_Happy_Day.Model.Interfaces;

namespace Wedding_Happy_Day.Model.Services
{
    public class HallService : IHall
    {
        private DataBaseContext _context;

        public HallService(DataBaseContext context)
        {
            _context = context;

        }
        public async Task<Hall> CreateHall(Hall hall)
        {
            Hall Newhall = new Hall
            {
                Id = hall.Id,
                Name = hall.Name,
                Email = hall.Email,
                Phone = hall.Phone,
                Price = hall.Price,
                Address = hall.Address,
                Description = hall.Description,
                Logo = hall.Logo,

            };
            _context.Entry(hall).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return Newhall;
        }

        public async Task DeleteHall(int Id)
        {
            Hall hall = await _context.Halls.FindAsync(Id);
            _context.Entry(hall).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<Hall> GetHall(int Id)
        {
            var HallDetails = await _context.Halls
                 .Include(c => c.Wedding)

                               .FirstOrDefaultAsync(n => n.Id == Id);

            return HallDetails;
        }

        public async Task<List<Hall>> GetHalls()
        {
            return await _context.Car_rentals.Include(x => x.Wedding).Select(hall => new Hall
            {
                Id = hall.Id,
                Name = hall.Name,
                Email = hall.Email,
                Phone = hall.Phone,
                Price = hall.Price,
                Address = hall.Address,
                Description = hall.Description,
                Logo = hall.Logo,

            }).ToListAsync();
        }

        public async Task<Hall> UpdateHall(int Id, Hall hall)
        {
            Hall UpdateHall = new Hall
            {
                Id = hall.Id,
                Name = hall.Name,
                Email = hall.Email,
                Phone = hall.Phone,
                Price = hall.Price,
                Address = hall.Address,
                Description = hall.Description,
                Logo = hall.Logo,
            };
            _context.Entry(hall).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return UpdateHall;
        }
    }
}
