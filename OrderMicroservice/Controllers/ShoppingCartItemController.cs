using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderMicroservice.ApplicationCore.Contracts.IRepositories;
using OrderMicroservice.Infrastructure.Repositories;

namespace OrderMicroservice.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShoppingCartItemController : ControllerBase
    {
        private readonly IShoppingCartItemRepositoryAsync _repo;
        public ShoppingCartItemController(IShoppingCartItemRepositoryAsync shoppingCartItemRepositoryAsync)
        {
            _repo = shoppingCartItemRepositoryAsync;
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteShoppingCartItemById(int id)
        {
            return Ok(await _repo.DeleteAsync(id));
        }
    }
}
