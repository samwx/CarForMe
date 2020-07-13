using System.Threading.Tasks;

namespace Vehicle
{
    public interface IRequestUtils<T>
    {
        public Task<T> GetRequest(string path);
    }
}