using RestSharp;
using System.Text.Json;
using Tasks.Sweeft.CountriesAPI.Models;

namespace Tasks.Sweeft.CountriesAPI
{
    public class RestService
    {
        private readonly RestClient _client;

        public RestService(string baseUrl)
        {
            _client = new RestClient(baseUrl);
        }

        public async Task<List<Country>> GetCountries(string resource)
        {
            try
            {
                var request = new RestRequest(resource, Method.Get);
                var response = await _client.ExecuteAsync(request);
                return JsonSerializer.Deserialize<List<Country>>(response.Content);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
