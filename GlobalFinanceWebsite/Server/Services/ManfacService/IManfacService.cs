using GlobalFinanceWebsite.Shared;
using Microsoft.AspNetCore.Mvc;

namespace GlobalFinanceWebsite.Server.Services.ManfacService
{
    public interface IManfacService
    {
        Task<List<Manfac>> GetManfacs();

        Task<Manfac> GetManfacByUrl(string manfacUrl);
    }
}
