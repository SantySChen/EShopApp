using Microsoft.EntityFrameworkCore;
using ReviewsMicroservice.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewsMicroservice.Infrastructure.Data
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options) 
        { 
        }

        public DbSet<Customer_Review> Customer_Reviews { get; set; }
    }
}
