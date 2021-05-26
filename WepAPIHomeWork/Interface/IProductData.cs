using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entities;

namespace WebApplication.Interface
{
    public interface IProductData
    {
        Task<List<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<int> SaveProductAsync(Product product);
        Task<int> DeleteProductAsync(int id);
    }
}
