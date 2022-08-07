using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wedding_Happy_Day.Model.Interfaces
{
   public interface IBeautyCenter
    {
        Task<List<Beauty_Center>> GetBeautyCenters();

        Task<Beauty_Center> CreateBeautyCenter(Beauty_Center Beauty);

        Task<Beauty_Center> GetBeautyCenter(int Id);

        Task<Beauty_Center> UpdateBeautyCenter(int Id, Beauty_Center Beauty);

        Task DeleteBeautyCenter(int Id);
    }
}
