using System.Threading.Tasks;
using VehicleAPI.Domain;

namespace VehicleAPI.Repository
{
    public interface IVehicleFipeRepository
    {
        public Task<FipeBrand[]> GetBrands();
        public Task<FipeVehicleExcerpt[]> GetVehiclesByBrand(int id);
        public Task<FipeVehicleModel[]> GetVehicleByBrand(int brandId, int vehicleId);
        public Task<FipeVehicle> GetVehicleDetail(int brandId, int vehicleId, string vehicleModel);
    }
}