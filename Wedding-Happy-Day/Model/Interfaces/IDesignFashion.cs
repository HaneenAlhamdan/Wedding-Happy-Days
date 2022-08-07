using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wedding_Happy_Day.Model.Interfaces
{
    public interface IDesignFashion
    {
        Task<List<Design_Fashion>> GetDesignFashions();

        Task<Design_Fashion> CreateDesignFashion(Design_Fashion DesignFashion);

        Task<Design_Fashion> GetDesignFashion(int Id);

        Task<Design_Fashion> UpdateDesignFashion(int Id, Design_Fashion DesignFashion);

        Task DeleteDesignFashion(int Id);
    }
}
