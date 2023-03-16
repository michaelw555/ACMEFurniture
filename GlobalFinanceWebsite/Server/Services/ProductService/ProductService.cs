using GlobalFinanceWebsite.Server.Data;
using GlobalFinanceWebsite.Server.Services.ManfacService;
using GlobalFinanceWebsite.Shared;
using Microsoft.EntityFrameworkCore;

namespace GlobalFinanceWebsite.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IManfacService _manfacService;

        private readonly ApplicationDbContext _context;

        public ProductService(IManfacService manfacService, ApplicationDbContext context)
        {
            _context = context;
            _manfacService = manfacService;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Product.ToListAsync();
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = _context.Product.FirstOrDefault(p => p.Id == id);
            return product;
        }


        public async Task<List<Product>> GetProductsByManfac(string manfacUrl)
        {
            Manfac manfac = await _manfacService.GetManfacByUrl(manfacUrl);
            return _context.Product.Where(p => p.ManfacId == manfac.Id).ToList();
        }

       
    }
}
