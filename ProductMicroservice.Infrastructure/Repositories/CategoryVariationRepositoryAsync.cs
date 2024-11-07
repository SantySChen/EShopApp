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
    public class CategoryVariationRepositoryAsync : BaseRepositoryAsync<Category_Variation>, ICategoryVariationRepositoryAsync
    {
        EShopDbContext _context;
        public CategoryVariationRepositoryAsync(EShopDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category_Variation>> GetByCategoryIdAsync(int categoryId)
        {
            return await _context.Category_Variations
                .Include(x => x.Product_Category)
                .Where(x => x.Product_Category.Id == categoryId)
                .ToListAsync();
        }
    }
}
