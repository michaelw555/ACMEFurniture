using GlobalFinanceWebsite.Server.Services.ProductService;
using GlobalFinanceWebsite.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GlobalFinanceWebsite.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            return Ok(await _productService.GetAllProducts());
        }

        [HttpGet("Manfac/{manfacUrl}")]
        public async Task<ActionResult<List<Product>>> GetProductsByManfac(string manfacUrl)
        {
            return Ok(await _productService.GetProductsByManfac(manfacUrl));

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return Ok(await _productService.GetProduct(id));
        }
    }
}