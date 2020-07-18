using Newtonsoft.Json;

namespace VehicleAPI.Domain
{
    public class FipeVehicleExcerpt
    {
        public string Key { get; set; }
        
        public string Name { get; set; }
        
        public int Id { get; set; }
        
        [JsonProperty("fipe_name")]
        public string FipeName { get; set; }
        
        [JsonProperty("fipe_marca")]
        public string FipeBrand { get; set; }
    }
}