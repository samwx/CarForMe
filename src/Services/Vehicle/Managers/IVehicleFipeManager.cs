using System.Threading.Tasks;
using Vehicle.Models;

namespace Vehicle.Managers
{
    public interface IVehicleFipeManager
    {
        public Task<FipeBrand[]> GetBrands();
        public Task<FipeVehicleExcerpt[]> GetVehiclesByBrand(int id);
    }
}