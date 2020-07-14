using System.Threading.Tasks;
using Vehicle.Models;

namespace Vehicle.Managers
{
    public interface IVehicleFipeManager
    {
        public Task<FipeBrand[]> GetBrands();
        public Task<FipeVehicleExcerpt[]> GetVehiclesByBrand(int id);
        public Task<FipeVehicleModel[]> GetVehicleByBrand(int brandId, int vehicleId);
        public Task<FipeVehicle> GetVehicleDetail(int brandId, int vehicleId, string vehicleModel);
    }
}