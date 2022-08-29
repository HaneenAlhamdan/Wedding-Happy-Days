using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wedding_Happy_Day.Data;
using Wedding_Happy_Day.Model.Interfaces;

namespace Wedding_Happy_Day.Model.Services
{
    public class CarRentalService : ICarRental
    {
        private DataBaseContext _context;

        public CarRentalService(DataBaseContext context)
        {
            _context = context;

        }
        public async Task<Car_rental> CreateCarRental(Car_rental CarRental)
        {
            Car_rental NewCarRental = new Car_rental
            {
                Id = CarRental.Id,
                Name = CarRental.Name,
                Email = CarRental.Email,
                Phone = CarRental.Phone,
                Price = CarRental.Price,
                Address = CarRental.Address,
                Description = CarRental.Description,
                Logo = CarRental.Logo,
               
            };
            _context.Entry(CarRental).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return NewCarRental;
        }

        public async Task DeleteCarRental(int Id)
        {
            Car_rental CarRental = await _context.Car_rentals.FindAsync(Id);
            _context.Entry(CarRental).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<Car_rental> GetCarRental(int Id)
        {
            var CarRentalDetails = await _context.Car_rentals
               .Include(c => c.Wedding)

                             .FirstOrDefaultAsync(n => n.Id == Id);

            return CarRentalDetails;
        }

        public async Task<List<Car_rental>> GetCarRentals()
        {
            return await _context.Car_rentals.Include(x => x.Wedding).Select(CarRental => new Car_rental
            {
                Id = CarRental.Id,
                Name = CarRental.Name,
                Email = CarRental.Email,
                Phone = CarRental.Phone,
                Price = CarRental.Price,
                Address = CarRental.Address,
                Description = CarRental.Description,
                Logo = CarRental.Logo,

            }).ToListAsync();
        }

        public async Task<Car_rental> UpdateCarRental(int Id, Car_rental CarRental)
        {
            Car_rental UpdateCarRental = new Car_rental
            {
                Id = CarRental.Id,
                Name = CarRental.Name,
                Email = CarRental.Email,
                Phone = CarRental.Phone,
                Price = CarRental.Price,
                Address = CarRental.Address,
                Description = CarRental.Description,
                Logo = CarRental.Logo,
            };
            _context.Entry(CarRental).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return UpdateCarRental;
        }
    }
}
