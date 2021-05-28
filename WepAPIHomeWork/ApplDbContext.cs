using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication.Entities;

namespace WepAPIHomeWork
{
    public class ApplDbContext : DbContext
    {
        public ApplDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new List<Product>() {
                new Product() { Id = 1 ,Image = null, Description = "Описание продукта 1", Name = "Продукт 1" },
                new Product() { Id = 2, Image = null, Description = "Описание продукта 2", Name = "Продукт 2" },
                new Product() { Id = 3, Image = null, Description = "Описание продукта 3", Name = "Продукт 3" }
                });
        }

        public DbSet<Product> Products { get; set; }
    }
}
