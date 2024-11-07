using Microsoft.EntityFrameworkCore;
using ShippingMicroservice.ApplicationCore.Contracts.IRepositories;
using ShippingMicroservice.ApplicationCore.Entities;
using ShippingMicroservice.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingMicroservice.Infrastructure.Repositories
{
    public class ShipperRepositoryAsync : BaseRepositoryAsync<Shipper>, IShipperRepositoryAsync
    {
        private readonly EShopDbContext _context;
        public ShipperRepositoryAsync(EShopDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Region>> GetRegionAsync(int id)
        {
            var RegionIds = await _context.Shipper_Regions
                .Where(x => x.Shipper_Id == id)
                .Select(x => x.Region_Id)
                .ToListAsync();
            
            return await _context.Regions
                .Where(x => RegionIds.Contains(x.Id))
                .ToListAsync();

        }

        public async Task<Region> GetRegionByIdAsync(int id)
        {
            return await _context.Regions
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
        }
    }
}
