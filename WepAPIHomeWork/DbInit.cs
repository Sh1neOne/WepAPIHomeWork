using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Entities;

namespace WepAPIHomeWork
{
    public static class DbInit
    {
        public static void Initialize(ApplDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Products.Any()) return;

            var products = new List<Product>()
            {
                new Product(){Image = null, Description = "Описание продукта 1", Name = "Продукт 1"},
                new Product(){Image = null, Description = "Описание продукта 1", Name = "Продукт 1"},
                new Product(){Image = null, Description = "Описание продукта 1", Name = "Продукт 1"}
            };
            foreach (var item in products)
            {
                context.Products.Add(item);
            }
            context.SaveChanges();
        }
    }
}
