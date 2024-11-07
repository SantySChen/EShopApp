using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductMicroservice.ApplicationCore.Contracts.IRepositories;
using ProductMicroservice.ApplicationCore.Entities;

namespace ProductMicroservice.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductRepositoryAsync _repo;
        public ProductController(IProductRepositoryAsync productRepositoryAsync) 
        {
            _repo = productRepositoryAsync;
        }

        [HttpGet]
        public async Task<IActionResult> GetListProducts()
        {
            return Ok(await _repo.GetAllAsync());
        }

        [HttpGet]
        public async Task<IActionResult> GetProductById(int id)
        {
            return Ok(await _repo.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Save(Product product)
        {
            return Ok(await _repo.InsertAsync(product));
        }

        [HttpPut]
        public async Task<IActionResult> Update(Product product)
        {
            return Ok(await _repo.UpdateAsync(product));
        }

        [HttpPut]
        public async Task<IActionResult> InActive(int id)
        {
            return Ok(await _repo.ActiveAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetProductByCategoryId(int id)
        {
            return Ok(await _repo.GetByCategoryIdAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> GetProductByName(string name)
        {
            return Ok(await _repo.GetByNameAsync(name));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            return Ok(await _repo.DeleteAsync(id));
        }
    }
}
