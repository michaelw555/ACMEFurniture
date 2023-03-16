using GlobalFinanceWebsite.Shared;

namespace GlobalFinanceWebsite.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action OnChange;
        List<Product> Products { get; set; }
        Task LoadProducts(string manfacUrl = null);
        Task<Product> GetProduct(int id);
    }
}
