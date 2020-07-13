using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Vehicle.Models
{
    public class FipeBrand
    {
        public int Id { get; set; }
        
        public string Key { get; set; }
        
        public string Name { get; set; }
        
        [JsonProperty("fipe_name")]
        public string FipeName { get; set; }
    }
}