using Microsoft.EntityFrameworkCore;
using ProductMicroservice.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMicroservice.Infrastructure.Data
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options) 
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Product_Category> Product_Categories { get; set; }
        public DbSet<Category_Variation> Category_Variations { get; set; }
        public DbSet<Variation_Value> Variation_Values { get; set; }
        public DbSet<Product_Variation_Value> Product_Variation_Values { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product_Variation_Value>()
                .HasKey(f => new { f.Product_Id, f.Variation_Value_Id });

            modelBuilder.Entity<Product_Variation_Value>()
                .HasOne(f => f.Product)
                .WithMany(x => x.Product_Variation_Values)
                .HasForeignKey(x => x.Product_Id);

            modelBuilder.Entity<Product_Variation_Value>()
                .HasOne(x => x.Variation_Value)
                .WithMany(x => x.Product_Variation_Values)
                .HasForeignKey(x => x.Variation_Value_Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
