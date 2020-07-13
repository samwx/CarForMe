using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Vehicle.Models;

namespace Vehicle.Managers
{
    public class VehicleFipeManager : IVehicleFipeManager
    {
        private IHttpClientFactory _clientFactory;

        public VehicleFipeManager(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        
        public async Task<FipeBrand[]> GetBrands()
        {
            var request = new RequestUtils<FipeBrand[]>(_clientFactory);
            var brands = await request.GetRequest(String.Format(Constants.FipeApiUrlBase, "carros/marcas"));

            return brands.ToArray();
        }

        public async Task<FipeVehicleExcerpt[]> GetVehiclesByBrand(int brandId)
        {
            var request = new RequestUtils<FipeVehicleExcerpt[]>(_clientFactory);
            var vehicles = await request.GetRequest(String.Format(Constants.FipeApiUrlBase, $"carros/veiculos/{brandId}"));

            return vehicles.ToArray();
        }
    }
}