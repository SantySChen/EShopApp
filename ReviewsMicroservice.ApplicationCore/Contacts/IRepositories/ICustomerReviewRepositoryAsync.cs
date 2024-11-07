using ReviewsMicroservice.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewsMicroservice.ApplicationCore.Contacts.IRepositories
{
    public interface ICustomerReviewRepositoryAsync : IRepositoryAsync<Customer_Review>
    {
        Task<Customer_Review> GetByCustomerIdAsync(int id);
        Task<Customer_Review> GetByProductIdAsync(int id);

        Task<IEnumerable<Customer_Review>> GetByYearAsync(int year);

        Task<bool> ApproveAsync(int id);
        Task<bool> RejectAsync(int id);
    }
}
