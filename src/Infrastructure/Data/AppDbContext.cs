using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HandTools.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<HandTools.ApplicationCore.Entities.Product> Product { get; set; } = default!;

        public DbSet<HandTools.ApplicationCore.Entities.ProductCategory> ProductCategory { get; set; } = default!;
        public DbSet<HandTools.ApplicationCore.Entities.Cart> Cart { get; set; } = default!;
        public DbSet<HandTools.ApplicationCore.Entities.CartDetail> CartDetail { get; set; } = default!;
        
    }
}
