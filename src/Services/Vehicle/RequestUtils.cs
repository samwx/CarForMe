using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Vehicle.Models;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace Vehicle
{
    public class RequestUtils<T> : IRequestUtils<T>
    {
        private IHttpClientFactory _clientFactory;

        public RequestUtils(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        
        public async Task<T> GetRequest(string path)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, path);
                
                var client = _clientFactory.CreateClient();
                var response = await client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var responseStream = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<T>(responseStream);

                    return result;
                }

                return default(T);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}