using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Products_Amazon.Models;

namespace Products_Amazon.Data
{
    public class Products_AmazonContext : DbContext
    {
        public Products_AmazonContext (DbContextOptions<Products_AmazonContext> options)
            : base(options)
        {
        }

        public DbSet<Products_Amazon.Models.Products> Products { get; set; } = default!;
    }
}
