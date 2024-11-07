using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductMicroservice.ApplicationCore.Contracts.IRepositories;
using ProductMicroservice.ApplicationCore.Entities;

namespace ProductMicroservice.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryVariationController : ControllerBase
    {
        ICategoryVariationRepositoryAsync _repo;
        public CategoryVariationController(ICategoryVariationRepositoryAsync categoryVariationRepositoryAsync)
        {
            _repo = categoryVariationRepositoryAsync;
        }

        [HttpPost]
        public async Task<IActionResult> Save(Category_Variation cv)
        {
            return Ok(await _repo.InsertAsync(cv));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _repo.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoryVariationById(int id)
        {
            return Ok(await _repo.GetByIdAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoryVariationByCategoryId(int id)
        {
            return Ok(await _repo.GetByCategoryIdAsync(id));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _repo.DeleteAsync(id));
        }
    }
        
}
