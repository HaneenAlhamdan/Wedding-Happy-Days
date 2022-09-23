using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wedding_Happy_Day.Data;
using Wedding_Happy_Day.Model.Interfaces;

namespace Wedding_Happy_Day.Model.Services
{
    public class DesignFashionService : IDesignFashion
    {

        private DataBaseContext _context;

        public DesignFashionService(DataBaseContext context)
        {
            _context = context;

        }
        public async Task<Design_Fashion> CreateDesignFashion(Design_Fashion DesignFashion)
        {
            Design_Fashion NewDesignFashion = new Design_Fashion
            {
                Id = DesignFashion.Id,
                Name = DesignFashion.Name,
                Email = DesignFashion.Email,
                Phone = DesignFashion.Phone,
                Price = DesignFashion.Price,
                Address = DesignFashion.Address,
                Description = DesignFashion.Description,
                Logo = DesignFashion.Logo,

            };
            _context.Entry(DesignFashion).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return NewDesignFashion;
        }

        public async Task DeleteDesignFashion(int Id)
        {
            Design_Fashion DesignFashion = await _context.Design_Fashions.FindAsync(Id);
            _context.Entry(DesignFashion).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<Design_Fashion> GetDesignFashion(int Id)
        {
            var DesignFashionDetails = await _context.Design_Fashions
                .Include(c => c.Wedding)

                              .FirstOrDefaultAsync(n => n.Id == Id);

            return DesignFashionDetails;
        }

        public async Task<List<Design_Fashion>> GetDesignFashions()
        {
            return await _context.Car_rentals.Include(x => x.Wedding).Select(DesignFashion => new Design_Fashion
            {
                Id = DesignFashion.Id,
                Name = DesignFashion.Name,
                Email = DesignFashion.Email,
                Phone = DesignFashion.Phone,
                Price = DesignFashion.Price,
                Address = DesignFashion.Address,
                Description = DesignFashion.Description,
                Logo = DesignFashion.Logo,

            }).ToListAsync();
        }

        public async Task<Design_Fashion> UpdateDesignFashion(int Id, Design_Fashion DesignFashion)
        {
            Design_Fashion UpdateDesignFashion = new Design_Fashion
            {
                Id = DesignFashion.Id,
                Name = DesignFashion.Name,
                Email = DesignFashion.Email,
                Phone = DesignFashion.Phone,
                Price = DesignFashion.Price,
                Address = DesignFashion.Address,
                Description = DesignFashion.Description,
                Logo = DesignFashion.Logo,
            };
            _context.Entry(DesignFashion).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return UpdateDesignFashion;
        }
    }
}
