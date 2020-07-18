using Newtonsoft.Json;

namespace VehicleAPI.Domain
{
    public class FipeVehicleModel
    {
        public string Key { get; set; }
        
        [JsonProperty("name")]
        public string ModelName { get; set; }
        
        public string Id { get; set; }

        [JsonProperty("fipe_codigo")]
        public string FipeCode { get; set; }
        
        [JsonProperty("fipe_marca")]
        public string FipeBrand { get; set; }
        
        [JsonProperty("marca")]
        public string Brand { get; set; }
        
        [JsonProperty("veiculo")]
        public string VehicleName { get; set; }
    }
}