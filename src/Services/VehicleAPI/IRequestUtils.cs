using System.Threading.Tasks;

namespace VehicleAPI
{
    public interface IRequestUtils<T>
    {
        public Task<T> GetRequest(string path);
    }
}