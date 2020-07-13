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
    public class VehicleFipeController : ControllerBase
    {
        private readonly IVehicleFipeManager _vehicleFipeManager;

        public VehicleFipeController(IVehicleFipeManager vehicleFipeManager)
        {
            _vehicleFipeManager = vehicleFipeManager;
        }
            
        [HttpGet("brands")]
        public async Task<FipeBrand[]> Get()
        {
            return await _vehicleFipeManager.GetBrands();
            
        }

        [HttpGet("brands/vehicles/{brandId}")]
        public async Task<FipeVehicleExcerpt[]> GetVehicle(int brandId)
        {
            return await _vehicleFipeManager.GetVehiclesByBrand(brandId);
        }
    }
}