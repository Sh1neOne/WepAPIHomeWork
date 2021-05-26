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
        public ApplDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
