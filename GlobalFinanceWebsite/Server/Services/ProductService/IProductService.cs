using GlobalFinanceWebsite.Shared;
using Microsoft.EntityFrameworkCore;

namespace GlobalFinanceWebsite.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();

        Task<List<Product>> GetProductsByManfac(string manfacUrl);

        Task<Product> GetProduct(int id);
        Task AddRequest(Pinfo request);



    }
}
