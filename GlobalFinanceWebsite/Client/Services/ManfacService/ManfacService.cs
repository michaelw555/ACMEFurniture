using GlobalFinanceWebsite.Shared;
using System.ComponentModel;
using System.Net.Http.Json;

namespace GlobalFinanceWebsite.Client.Services.ManfacService
{
    public class ManfacService : IManfacService
    {
        public List<Manfac> Manfacs { get; set; } = new List<Manfac>();
        private readonly HttpClient _http;

        public ManfacService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadManfacs()
        {
            Manfacs = await _http.GetFromJsonAsync<List<Manfac>>("api/Manfac");
        }
    }
}
