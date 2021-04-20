using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace BerryClient.Services
{
    public class ProductsService
    {
        public async Task<List<IProduct>> GetProducts()
        {
            var serviceCollection = new ServiceCollection();
                //serviceCollection.AddDefaultScalarSerializers();
                serviceCollection.AddInventoryClient();
                serviceCollection.AddHttpClient("InventoryClient")
                    .ConfigureHttpClient(client =>
                        client.BaseAddress = new Uri("http://localhost:3000/graphql"));
                IServiceProvider services = serviceCollection.BuildServiceProvider();
                var client = services.GetRequiredService<IInventoryClient>();
            
            var result = await client.GetProductsAsync();            

            return result.Data.Products.ToList();
        }
    }
}