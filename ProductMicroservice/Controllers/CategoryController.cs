using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductMicroservice.ApplicationCore.Contracts.IRepositories;
using ProductMicroservice.ApplicationCore.Entities;

namespace ProductMicroservice.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepositoryAsync _repo;
        public CategoryController(ICategoryRepositoryAsync categoryRepositoryAsync)  
        {
            _repo = categoryRepositoryAsync;
        }

        [HttpPost]
        public async Task<IActionResult> SaveCategory(Product_Category category) 
        {
            return Ok(await _repo.InsertAsync(category));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategory()
        {
            return Ok(await _repo.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            return Ok(await _repo.GetByIdAsync(id));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _repo.DeleteAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoryByParentCategoryId(int id)
        {
            return Ok(await _repo.GetByParentCategoryIdAsync(id));
        }
    }
}
