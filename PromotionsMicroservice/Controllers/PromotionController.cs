using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PromotionsMicroservice.ApplicatonCore.Contracts.IRepositories;

namespace PromotionsMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        private readonly IPromotionRepositoryAsync _repo;
        public PromotionController(IPromotionRepositoryAsync repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GET()
        {
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> POST()
        {
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> PUT()
        {
            return NoContent(); 
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

        [HttpGet("promotionByProductName")]
        public async Task<IActionResult> GetByProductName(string productName)
        {
            return Ok(await _repo.GetByProductNameAsync(productName));
        }

        [HttpGet("activePromotions")]
        public async Task<IActionResult> ActivePromotions()
        {
            return Ok(await _repo.FindActivePromtionsAsync());
        }
    }
}
