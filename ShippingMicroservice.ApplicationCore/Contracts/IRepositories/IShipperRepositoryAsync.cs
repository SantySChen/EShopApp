using ShippingMicroservice.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingMicroservice.ApplicationCore.Contracts.IRepositories
{
    public interface IShipperRepositoryAsync : IRepositoryAsync<Shipper>
    {
        Task<IEnumerable<Region>> GetRegionAsync(int id);
        Task<Region> GetRegionByIdAsync(int id);
    }
}
