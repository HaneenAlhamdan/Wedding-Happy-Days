using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wedding_Happy_Day.Model.Interfaces;

namespace Wedding_Happy_Day.Model.Services
{
    public class BeautyCenterService : IBeautyCenter
    {
        public Task<Beauty_Center> CreateBeautyCenter(Beauty_Center Product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBeautyCenter(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Beauty_Center> GetBeautyCenter(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Beauty_Center>> GetBeautyCenters()
        {
            throw new NotImplementedException();
        }

        public Task<Beauty_Center> UpdateBeautyCenter(int Id, Beauty_Center category)
        {
            throw new NotImplementedException();
        }
    }
}
