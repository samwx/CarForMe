using System.Collections.Generic;
using System.Threading.Tasks;
using DealerAPI.Domain;

namespace DealerAPI.Repository
{
    public class DealerRepository : IRepository<Dealer>
    {
        public Task<List<Dealer>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Dealer> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Dealer> Add(Dealer entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<Dealer> Update(Dealer entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<Dealer> Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}