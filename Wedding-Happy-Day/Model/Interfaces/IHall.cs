using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wedding_Happy_Day.Model.Interfaces
{
    public interface IHall
    {
        Task<List<Hall>> GetHalls();

        Task<Hall> CreateHall(Hall hall);

        Task<Hall> GetHall(int Id);

        Task<Hall> UpdateHall(int Id, Hall hall);

        Task DeleteHall(int Id);
    }
}
