using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductMicroservice.ApplicationCore.Contracts.IRepositories;
using ProductMicroservice.ApplicationCore.Entities;

namespace ProductMicroservice.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VariationValueController : ControllerBase
    {
        IVariationValueRepositoryAsync _repo;
        public VariationValueController(IVariationValueRepositoryAsync repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async Task<IActionResult> Save(Variation_Value vv)
        {
            return Ok(await _repo.InsertAsync(vv));
        }

        [HttpGet]
        public async Task<IActionResult> GetVariatonId(int id)
        {
            return Ok(await _repo.GetByIdAsync(id));
        }
    }
}
