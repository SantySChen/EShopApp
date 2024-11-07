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
    public class VariationValueRepositoryAsync : BaseRepositoryAsync<Variation_Value>, IVariationValueRepositoryAsync
    {
        public VariationValueRepositoryAsync(EShopDbContext context) : base(context)
        {
        }
    }
}
