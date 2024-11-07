using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderMicroservice.ApplicationCore.Contracts.IRepositories;
using OrderMicroservice.ApplicationCore.Entities;
using OrderMicroservice.Infrastructure.Repositories;

namespace OrderMicroservice.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCartRepositoryAsync _repo;
        public ShoppingCartController(IShoppingCartRepositoryAsync shoppingCartRepositoryAsync)
        {
            _repo = shoppingCartRepositoryAsync;
        }

        [HttpGet]
        public async Task<IActionResult> GetShoppingCartByCustomerId(int id)
        {
            return Ok(await _repo.GetByCustomerId(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveShoppingCart(Shopping_Cart shopping_Cart) 
        {
            return Ok(await _repo.InsertAsync(shopping_Cart));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteShoppingCart(int id)
        {
            return Ok(await _repo.DeleteAsync(id));
        }
    }
}
