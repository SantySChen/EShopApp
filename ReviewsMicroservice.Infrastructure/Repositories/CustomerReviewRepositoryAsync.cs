using Microsoft.EntityFrameworkCore;
using ReviewsMicroservice.ApplicationCore.Contacts.IRepositories;
using ReviewsMicroservice.ApplicationCore.Entities;
using ReviewsMicroservice.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewsMicroservice.Infrastructure.Repositories
{
    public class CustomerReviewRepositoryAsync : BaseRepositoryAsync<Customer_Review>, ICustomerReviewRepositoryAsync
    {
        private readonly EShopDbContext _context;
        public CustomerReviewRepositoryAsync(EShopDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> ApproveAsync(int id)
        {
            var entity = await _context.Customer_Reviews.FindAsync(id);
            if(await _context.SaveChangesAsync() == 1)
            {
                return true;
            }
            return false;
        }

        public async Task<Customer_Review> GetByCustomerIdAsync(int id)
        {
            return await _context.Customer_Reviews
                .Where(x => x.Customer_Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<Customer_Review> GetByProductIdAsync(int id)
        {
            return await _context.Customer_Reviews
                .Where(x => x.Product_Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Customer_Review>> GetByYearAsync(int year)
        {
            return await _context.Customer_Reviews
                .Where(x => x.Review_Date.Year == year)
                .ToListAsync();
        }

        public async Task<bool> RejectAsync(int id)
        {
            var entity = await _context.Customer_Reviews.FindAsync(id);
            if(await _context.SaveChangesAsync() == 0)
            {
                return true;
            }
            return false;
        }
    }
}
