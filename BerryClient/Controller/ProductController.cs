using System.Threading.Tasks;
using BerryClient.Services;
using Microsoft.AspNetCore.Mvc;

namespace BerryClient.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var service = new ProductsService();

            var response = await service.GetProducts();
            return Ok(response);
        }
    }
}