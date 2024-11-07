using Microsoft.EntityFrameworkCore;
using OrderMicroservice.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMicroservice.Infrastructure.Data
{
    public class EShopDbContext : DbContext
    {
        public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options) 
        { 
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Detail> Order_Details { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User_Address> User_Addresses { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Shopping_Cart> Shopping_Carts { get; set; }
        public DbSet<Shopping_Cart_Item> Shopping_Cart_Items { get; set; }
        public DbSet<Payment_Type> Payment_Types { get; set; }
        public DbSet<Payment_Method> Payment_Methods { get; set; }
    }
}
