using Microsoft.EntityFrameworkCore;
using PromotionsMicroservice.ApplicatonCore.Contracts.IRepositories;
using PromotionsMicroservice.ApplicatonCore.Entities;
using PromotionsMicroservice.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionsMicroservice.Infrastructure.Repositories
{
    public class PromotionRepositoryAsync : BaseRepositoryAsync<Promotion_Sale>, IPromotionRepositoryAsync
    {
        private readonly EShopDbContext _context;
        public PromotionRepositoryAsync(EShopDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Promotion_Sale>> FindActivePromtionsAsync()
        {
            var today = DateTime.Now;

            return await _context.Promotion_Sales
                .Where(x => x.Start_Date >= today && x.End_Date <= today)
                .ToListAsync();
        }

        public async Task<IEnumerable<Promotion_Sale>> GetByProductNameAsync(string productName)
        {
            return await _context.Promotion_Details
                .Where(x => x.Product_Category_Name == productName)
                .Select(x => x.Promotion_Sale)
                .ToListAsync();
        }
    }
}
