using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wedding_Happy_Day.Model.Interfaces;

namespace Wedding_Happy_Day.Model.Services
{
    public class CarRentalService : ICarRental
    {
        public Task<Car_rental> CreateCarRental(Car_rental CarRental)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCarRental(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Car_rental> GetCarRental(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Car_rental>> GetCarRentals()
        {
            throw new NotImplementedException();
        }

        public Task<Car_rental> UpdateCarRental(int Id, Car_rental CarRental)
        {
            throw new NotImplementedException();
        }
    }
}
