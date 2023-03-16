using GlobalFinanceWebsite.Shared;
using System.ComponentModel;

namespace GlobalFinanceWebsite.Client.Services.ManfacService
{
    interface IManfacService
    {
        List<Manfac> Manfacs { get; set; }
        Task LoadManfacs();
    }
}
