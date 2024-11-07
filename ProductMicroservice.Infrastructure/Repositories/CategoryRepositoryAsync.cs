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
    public class CategoryRepositoryAsync : BaseRepositoryAsync<Product_Category>, ICategoryRepositoryAsync
    {
        EShopDbContext _context;
        public CategoryRepositoryAsync(EShopDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Product_Category> GetByParentCategoryIdAsync(int id)
        {
            return await _context.Product_Categories
                .Where(x => x.Parent_Category_Id == id)
                .FirstOrDefaultAsync();
        }
    }
}
