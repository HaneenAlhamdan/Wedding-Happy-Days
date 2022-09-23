using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wedding_Happy_Day.Model.Interfaces
{
    public interface ICarRental
    {
        Task<List<Car_rental>> GetCarRentals();

        Task<Car_rental> CreateCarRental(Car_rental CarRental);

        Task<Car_rental> GetCarRental(int Id);

        Task<Car_rental> UpdateCarRental(int Id, Car_rental CarRental);

        Task DeleteCarRental(int Id);
    }
}
