using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vehicle.Managers;
using Vehicle.Models;

namespace Vehicle.Controllers
{
    [ApiController]
    [Route("api/fipe")]
    public class VehicleFipeController : ControllerBase, IVehicleFipeManager
    {
        private readonly IVehicleFipeManager _vehicleFipeManager;

        public VehicleFipeController(IVehicleFipeManager vehicleFipeManager)
        {
            _vehicleFipeManager = vehicleFipeManager;
        }
            
        [HttpGet("brands")]
        public async Task<FipeBrand[]> GetBrands()
        {
            return await _vehicleFipeManager.GetBrands();
        }

        [HttpGet("brands/vehicles/{brandId}")]
        public async Task<FipeVehicleExcerpt[]> GetVehiclesByBrand(int brandId)
        {
            return await _vehicleFipeManager.GetVehiclesByBrand(brandId);
        }

        [HttpGet("brands/vehicles/{brandId}/{vehicleId}")]
        public async Task<FipeVehicleModel[]> GetVehicleByBrand(int brandId, int vehicleId)
        {
            return await _vehicleFipeManager.GetVehicleByBrand(brandId, vehicleId);
        }

        [HttpGet("brands/vehicles/{brandId}/{vehicleId}/{vehicleModel}")]
        public async Task<FipeVehicle> GetVehicleDetail(int brandId, int vehicleId, string vehicleModel)
        {
            return await _vehicleFipeManager.GetVehicleDetail(brandId, vehicleId, vehicleModel);
        }
    }
}