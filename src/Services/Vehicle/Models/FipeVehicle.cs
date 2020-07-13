using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Vehicle.Models
{
    public class FipeVehicle
    {
        private float _normalizedPrice;
        
        public int Id { get; set; }
        
        [JsonProperty("ano_modelo")]
        public int YearModel { get; set; }
        
        [JsonProperty("marca")]
        public string Brand { get; set; }
        
        [JsonProperty("veiculo")]
        public string Vehicle { get; set; }

        [JsonProperty("preco")]
        public string Price { get; set; }

        public float NormalizedPrice
        {
            get => float.Parse(Price.Replace("R$", "").Trim());
            set => _normalizedPrice = value;
        }
        
        [JsonProperty("combustivel")]
        public string Fuel { get; set; }
        
        [JsonProperty("referencia")]
        public string Ref { get; set; }
        
        [JsonProperty("fipe_codigo")]
        public string FipeCode { get; set; }
        
        public string Key { get; set; }
    }
}