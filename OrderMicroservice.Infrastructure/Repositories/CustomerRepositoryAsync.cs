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
    public class CustomerRepositoryAsync : BaseRepositoryAsync<Customer>, ICustomerRepositoryAsync
    {
        EShopDbContext _context;
        public CustomerRepositoryAsync(EShopDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Address> GetAddressById(int id)
        {
            var result = await _context.User_Addresses
                .Where(x => x.Id == id)
                .Select(x => x.Address)
                .FirstOrDefaultAsync();
            return result;
        }

        public async Task<int> SaveCustomerAddress(Address address)
        {
            await _context.Set<Address>().AddAsync(address);
            return await _context.SaveChangesAsync();
        }
    }
}
