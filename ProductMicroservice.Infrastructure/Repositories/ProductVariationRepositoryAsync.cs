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
    public class ProductVariationRepositoryAsync : BaseRepositoryAsync<Product_Variation_Value>, IProductVariationRepositoryAsync
    {
        public ProductVariationRepositoryAsync(EShopDbContext context) : base(context)
        {
        }
    }
}
