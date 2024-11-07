using ProductMicroservice.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMicroservice.ApplicationCore.Contracts.IRepositories
{
    public interface IProductRepositoryAsync : IRepositoryAsync<Product>
    {
        Task<int> ActiveAsync(int id);
        Task<IEnumerable<Product>> GetByCategoryIdAsync(int id);

        Task<IEnumerable<Product>> GetByNameAsync(string name);
    }
}
