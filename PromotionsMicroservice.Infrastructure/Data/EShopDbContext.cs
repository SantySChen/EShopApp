using Microsoft.EntityFrameworkCore;
using PromotionsMicroservice.ApplicatonCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionsMicroservice.Infrastructure.Data
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options) 
        { 
        } 

        public DbSet<Promotion_Sale> Promotion_Sales { get; set; }
        public DbSet<Promotion_Detail> Promotion_Details { get; set; }
    }
}
