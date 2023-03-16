using GlobalFinanceWebsite.Shared;

namespace GlobalFinanceWebsite.Server.Services.ManfacService
{
    public class ManfacService : IManfacService
    {
        public List<Manfac> Manfacs { get; set; } = new List<Manfac>
            {
                new Manfac {Id = 1, Name = "Toyota", Url = "toyota", Icon = "book" },
                new Manfac {Id = 2,Name = "Tesla", Url = "tesla", Icon = "aperture" },
            };

        
        public async Task<List<Manfac>> GetManfacs()
        {
            return Manfacs;
        }

        public async Task<Manfac> GetManfacByUrl(string manfacUrl)
        {
            return Manfacs.FirstOrDefault(m => m.Url.ToLower().Equals(manfacUrl.ToLower()));
        }
    }
}
