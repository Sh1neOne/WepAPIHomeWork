using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entities;
using WebApplication.Interface;
using WepAPIHomeWork;

namespace WebApplication.Entities
{
    public class ProductRepository : IProductData
    {
        private readonly ApplDbContext context;

        public ProductRepository(ApplDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Product>> GetProductsAsync()
        {
            return await context.Products.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await context.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<int> SaveProductAsync(Product product)
        {
            context.Entry(product).State = product.Id == default ? EntityState.Added : EntityState.Modified;

            return await context.SaveChangesAsync();
        }

        public async Task<int> DeleteProductAsync(int id)
        {
            context.Products.Remove(new Product() {Id = id});
            return await context.SaveChangesAsync();
        }
    }
}
