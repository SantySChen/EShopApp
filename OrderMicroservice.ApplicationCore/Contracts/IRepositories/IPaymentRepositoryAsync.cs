using OrderMicroservice.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMicroservice.ApplicationCore.Contracts.IRepositories
{
    public interface IPaymentRepositoryAsync : IRepositoryAsync<Payment_Method>
    {
        Task<Payment_Method> GetByCustomerIdAsync(int id);
    }
}
