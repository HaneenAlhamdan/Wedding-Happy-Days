using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wedding_Happy_Day.Model.Interfaces;

namespace Wedding_Happy_Day.Model.Services
{
    public class HallService : IHall
    {
        public Task<Hall> CreateHall(Hall hall)
        {
            throw new NotImplementedException();
        }

        public Task DeleteHall(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Hall> GetHall(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Hall>> GetHalls()
        {
            throw new NotImplementedException();
        }

        public Task<Hall> UpdateHall(int Id, Hall hall)
        {
            throw new NotImplementedException();
        }
    }
}
