using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VehicleAPI.Domain;
using VehicleAPI.Repository;

namespace VehicleAPI.Controllers
{
    [ApiController]
    [Route("api/fipe")]
    public class VehicleFipeController : ControllerBase, IVehicleFipeRepository
    {
        private readonly IVehicleFipeRepository _vehicleFipeRepository;

        public VehicleFipeController(IVehicleFipeRepository vehicleFipeRepository)
        {
            _vehicleFipeRepository = vehicleFipeRepository;
        }
            
        [HttpGet("brands")]
        public async Task<FipeBrand[]> GetBrands()
        {
            return await _vehicleFipeRepository.GetBrands();
        }

        [HttpGet("brands/vehicles/{brandId}")]
        public async Task<FipeVehicleExcerpt[]> GetVehiclesByBrand(int brandId)
        {
            return await _vehicleFipeRepository.GetVehiclesByBrand(brandId);
        }

        [HttpGet("brands/vehicles/{brandId}/{vehicleId}")]
        public async Task<FipeVehicleModel[]> GetVehicleByBrand(int brandId, int vehicleId)
        {
            return await _vehicleFipeRepository.GetVehicleByBrand(brandId, vehicleId);
        }

        [HttpGet("brands/vehicles/{brandId}/{vehicleId}/{vehicleModel}")]
        public async Task<FipeVehicle> GetVehicleDetail(int brandId, int vehicleId, string vehicleModel)
        {
            return await _vehicleFipeRepository.GetVehicleDetail(brandId, vehicleId, vehicleModel);
        }
    }
}