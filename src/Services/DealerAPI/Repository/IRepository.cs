using System.Collections.Generic;
using System.Threading.Tasks;

namespace DealerAPI.Repository
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}