using ProductMicroservice.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMicroservice.ApplicationCore.Contracts.IRepositories
{
    public interface ICategoryVariationRepositoryAsync : IRepositoryAsync<Category_Variation>
    {
        Task<IEnumerable<Category_Variation>> GetByCategoryIdAsync(int categoryId);
    }
}
