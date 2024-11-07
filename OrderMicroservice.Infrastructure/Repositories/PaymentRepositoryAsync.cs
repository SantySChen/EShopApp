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
    public class PaymentRepositoryAsync : BaseRepositoryAsync<Payment_Method>, IPaymentRepositoryAsync
    {
        EShopDbContext _context;
        public PaymentRepositoryAsync(EShopDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Payment_Method> GetByCustomerIdAsync(int id)
        {
            var paymentId = await _context.Orders
                .Where(x => x.CustomerId == id)
                .Select(x => x.PaymentMethodId)
                .FirstOrDefaultAsync();
            return await _context.Payment_Methods
                .Where(x => x.Id == paymentId)
                .Select(x => x).FirstOrDefaultAsync();
        }
    }
}
