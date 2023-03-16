using GlobalFinanceWebsite.Shared;

namespace GlobalFinanceWebsite.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();

        Task<List<Product>> GetProductsByManfac(string manfacUrl);

        Task<Product> GetProduct(int id);
    }
}
