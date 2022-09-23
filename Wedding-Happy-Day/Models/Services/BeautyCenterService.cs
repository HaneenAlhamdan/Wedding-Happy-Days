using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wedding_Happy_Day.Data;
using Wedding_Happy_Day.Model.Interfaces;

namespace Wedding_Happy_Day.Model.Services
{
    public class BeautyCenterService : IBeautyCenter
    {
        private DataBaseContext _context;

        public BeautyCenterService(DataBaseContext context)
        {
            _context = context;

        }
        public async Task<Beauty_Center> CreateBeautyCenter(Beauty_Center Beauty)
        {
            Beauty_Center NewBeautyCenter = new Beauty_Center
            {
                Id = Beauty.Id,
                Name = Beauty.Name,
                Email = Beauty.Email,
                Phone = Beauty.Phone,
                Price = Beauty.Price,
                Address = Beauty.Address,
                Description = Beauty.Description,
                Logo = Beauty.Logo,
               
            };
            _context.Entry(Beauty).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return NewBeautyCenter;
        }


        public async Task DeleteBeautyCenter(int Id)
        {
            Beauty_Center Beauty = await _context.Beauty_Centers.FindAsync(Id);
            _context.Entry(Beauty).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<Beauty_Center> GetBeautyCenter(int Id)
        {
            var BeautyDetails = await _context.Beauty_Centers
                .Include(c => c.Wedding)
                
                              .FirstOrDefaultAsync(n => n.Id == Id);

            return BeautyDetails;
        }

        public async Task<List<Beauty_Center>> GetBeautyCenters()
        {
            return await _context.Beauty_Centers.Include(x => x.Wedding).Select(Beauty => new Beauty_Center
            {
                Id = Beauty.Id,
                Name = Beauty.Name,
                Email = Beauty.Email,
                Phone = Beauty.Phone,
                Price = Beauty.Price,
                Address = Beauty.Address,
                Description = Beauty.Description,
                Logo = Beauty.Logo,

            }).ToListAsync();
        }

        public async Task<Beauty_Center> UpdateBeautyCenter(int Id, Beauty_Center Beauty)
        {
            Beauty_Center UpdateBeautyCenter = new Beauty_Center
            {
                Id = Beauty.Id,
                Name = Beauty.Name,
                Email = Beauty.Email,
                Phone = Beauty.Phone,
                Price = Beauty.Price,
                Address = Beauty.Address,
                Description = Beauty.Description,
                Logo = Beauty.Logo,
            };
            _context.Entry(Beauty).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return UpdateBeautyCenter;
        }
    }
}
