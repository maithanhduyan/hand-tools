using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Web.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Web.Models.Product> Product { get; set; } = default!;

        public DbSet<Web.Models.ProductCategory> ProductCategory { get; set; } = default!;
        public DbSet<HandTools.ApplicationCore.Entities.Cart> Cart { get; set; } = default!;
        public DbSet<HandTools.ApplicationCore.Entities.CartDetail> CartDetail { get; set; } = default!;
        
    }
}
