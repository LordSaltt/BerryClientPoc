using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace BerryClient.Services
{
    public class ProductsService
    {
        private readonly IInventoryClient _client;

        public ProductsService(IInventoryClient client)
        {
            _client = client;
        }


        public async Task<List<IProduct>> GetProducts()
        {
            var result = await _client.GetProductsAsync();

            return result.Data.Products.ToList();
        }
    }
}