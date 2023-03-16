using GlobalFinanceWebsite.Server.Services.ManfacService;
using GlobalFinanceWebsite.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GlobalFinanceWebsite.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ManfacController : ControllerBase
    {
        private readonly IManfacService _manfacService;

        public ManfacController(IManfacService manfacService)
        {
            _manfacService = manfacService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Manfac>>> GetManfacs()
        {
            return Ok(await _manfacService.GetManfacs());
        }
    }
}
