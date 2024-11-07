using Microsoft.EntityFrameworkCore;
using ShippingMicroservice.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingMicroservice.Infrastructure.Data
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options) 
        { 
        }

        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Shipper_Region> Shipper_Regions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shipper_Region>()
                .HasKey(sr => new { sr.Region_Id, sr.Shipper_Id });

            modelBuilder.Entity<Shipper_Region>()
                .HasOne(x => x.Region)
                .WithMany(x => x.Shipper_Regions)
                .HasForeignKey(x => x.Region_Id);

            modelBuilder.Entity<Shipper_Region>()
                .HasOne(x => x.Shipper)
                .WithMany(x => x.Shipper_Regions)
                .HasForeignKey(x => x.Shipper_Id);
        }
    }
}
