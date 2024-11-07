using Microsoft.EntityFrameworkCore;
using ProductMicroservice.ApplicationCore.Contracts.IRepositories;
using ProductMicroservice.ApplicationCore.Entities;
using ProductMicroservice.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMicroservice.Infrastructure.Repositories
{
    public class ProductRepositoryAsync : BaseRepositoryAsync<Product>, IProductRepositoryAsync
    {
        EShopDbContext _context;
        public ProductRepositoryAsync(EShopDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> ActiveAsync(int id)
        {
            return await Task.FromResult(id);    
        }

        public async Task<IEnumerable<Product>> GetByCategoryIdAsync(int id)
        {
            return await _context.Products
                .Include(x => x.Product_Category)
                .Where(x => x.Product_Category.Id == id)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetByNameAsync(string name)
        {
            return await _context.Products
                .Where(x => x.Name == name)
                .ToListAsync();
        }
    }
}
