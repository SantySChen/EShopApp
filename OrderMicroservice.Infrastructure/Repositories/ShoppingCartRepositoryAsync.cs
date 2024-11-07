using Microsoft.EntityFrameworkCore;
using OrderMicroservice.ApplicationCore.Contracts.IRepositories;
using OrderMicroservice.ApplicationCore.Entities;
using OrderMicroservice.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMicroservice.Infrastructure.Repositories
{
    public class ShoppingCartRepositoryAsync : BaseRepositoryAsync<Shopping_Cart>, IShoppingCartRepositoryAsync
    {
        private readonly EShopDbContext _context;
        public ShoppingCartRepositoryAsync(EShopDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Shopping_Cart> GetByCustomerId(int id)
        {
            return await _context.Shopping_Carts
                .Where(x => x.CustomerId == id)
                .Select(x => x)
                .FirstOrDefaultAsync();
        }
    }
}
