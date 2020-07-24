using System.Collections.Generic;
using System.Threading.Tasks;
using DealerAPI.Data;
using DealerAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace DealerAPI.Repository
{
    public class DealerRepository : IRepository<Dealer>
    {
        private readonly CarForMeDbContext _context;

        public DealerRepository(CarForMeDbContext context)
        {
            _context = context;
        }
            
        public async Task<List<Dealer>> GetAll()
        {
            return await _context.Set<Dealer>().ToListAsync();
        }

        public async Task<Dealer> GetById(int id)
        {
            return await _context.Set<Dealer>().FindAsync(id);
        }

        public async Task<Dealer> Add(Dealer entity)
        {
            _context.Set<Dealer>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Dealer> Update(Dealer entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Dealer> Delete(int id)
        {
            var entity = await _context.Set<Dealer>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            _context.Set<Dealer>().Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}