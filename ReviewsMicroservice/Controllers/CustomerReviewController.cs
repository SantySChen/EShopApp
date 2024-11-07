using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReviewsMicroservice.ApplicationCore.Contacts.IRepositories;

namespace ReviewsMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerReviewController : ControllerBase
    {
        ICustomerReviewRepositoryAsync _repo;
        public CustomerReviewController(ICustomerReviewRepositoryAsync repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
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

        [HttpDelete("delete-{id}")]
        public async Task<IActionResult> DELETE(int id)
        {
            return Ok(await _repo.DeleteAsync(id));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _repo.GetByIdAsync(id));
        }

        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetByUserId(int userId)
        {
            return Ok(await _repo.GetByCustomerIdAsync(userId));
        }

        [HttpGet("product/{productId}")]
        public async Task<IActionResult> GetByProductId(int productId)
        {
            return Ok(await _repo.GetByProductIdAsync(productId));
        }

        [HttpGet("year/{year}")]
        public async Task<IActionResult> GetByYear(int year)
        {
            return Ok(await _repo.GetByYearAsync(year));
        }

        [HttpPut("approve/{id}")]
        public async Task<IActionResult> Approve(int id)
        {
            return Ok(await _repo.ApproveAsync(id));
        }

        [HttpPut("reject/{id}")]
        public async Task<IActionResult> Reject(int id)
        {
            return Ok(await _repo.RejectAsync(id));
        }

    }
}
