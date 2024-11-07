using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductMicroservice.ApplicationCore.Contracts.IRepositories;
using ProductMicroservice.ApplicationCore.Entities;

namespace ProductMicroservice.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductVariationController : ControllerBase
    {
        IProductVariationRepositoryAsync _repo;
        public ProductVariationController(IProductVariationRepositoryAsync repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async Task<IActionResult> Save(Product_Variation_Value pv)
        {
            return Ok(await _repo.InsertAsync(pv));
        }

        [HttpGet]
        public async Task<IActionResult> GetProductVariation()
        {
            return Ok(await _repo.GetAllAsync());
        }
    }
}
