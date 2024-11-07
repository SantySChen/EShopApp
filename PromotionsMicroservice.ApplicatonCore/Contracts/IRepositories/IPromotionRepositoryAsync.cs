using PromotionsMicroservice.ApplicatonCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionsMicroservice.ApplicatonCore.Contracts.IRepositories
{
    public interface IPromotionRepositoryAsync : IRepositoryAsync<Promotion_Sale>
    {
        Task<IEnumerable<Promotion_Sale>> GetByProductNameAsync(string productName);
        Task<IEnumerable<Promotion_Sale>> FindActivePromtionsAsync();
    }
}
