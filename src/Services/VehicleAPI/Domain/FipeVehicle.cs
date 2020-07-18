using Newtonsoft.Json;

namespace VehicleAPI.Domain
{
    public class FipeVehicle
    {
        public string Id { get; set; }
        
        [JsonProperty("ano_modelo")]
        public int YearModel { get; set; }
        
        [JsonProperty("marca")]
        public string Brand { get; set; }
        
        [JsonProperty("veiculo")]
        public string Vehicle { get; set; }

        [JsonProperty("preco")]
        public string Price { get; set; }
        
        [JsonProperty("combustivel")]
        public string Fuel { get; set; }
        
        [JsonProperty("referencia")]
        public string Ref { get; set; }
        
        [JsonProperty("fipe_codigo")]
        public string FipeCode { get; set; }
        
        public string Key { get; set; }
    }
}