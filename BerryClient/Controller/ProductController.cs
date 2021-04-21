using System;
using System.Threading.Tasks;
using BerryClient.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace BerryClient.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IInventoryClient _client;


        public ProductController(IInventoryClient client)
        {
            _client = client;         
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var service = new ProductsService(_client);

            var response = await service.GetProducts();
            return Ok(response);
        }
    }
}