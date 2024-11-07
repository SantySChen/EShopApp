using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShippingMicroservice.ApplicationCore.Contracts.IRepositories;
using ShippingMicroservice.ApplicationCore.Entities;

namespace ShippingMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {
        private readonly IShipperRepositoryAsync _repo;

        public ShipperController(IShipperRepositoryAsync repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _repo.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Save(Shipper ship)
        {
            return Ok(await _repo.InsertAsync(ship));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Shipper ship)
        {
            return Ok(await _repo.UpdateAsync(ship));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _repo.GetByIdAsync(id));
        }

        [HttpDelete("delete-{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _repo.DeleteAsync(id));
        }

        [HttpGet("region/{region}")]
        public async Task<IActionResult> GetRegion(int id)
        {
            var region = await _repo.GetRegionAsync(id);
            return Ok(region);
        }
        
    }
}
