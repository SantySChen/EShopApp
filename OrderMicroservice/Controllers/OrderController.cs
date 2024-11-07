using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderMicroservice.ApplicationCore.Contracts.IRepositories;
using OrderMicroservice.ApplicationCore.Entities;
using OrderMicroservice.Infrastructure.Repositories;

namespace OrderMicroservice.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepositoryAsync _order;
        public OrderController(IOrderRepositoryAsync orderRepositoryAsync)
        {
            _order = orderRepositoryAsync;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            return Ok(await _order.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> SaveTheNewOrder(Order order)
        {
            return Ok(await _order.InsertAsync(order));
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderByCustomerId(int id)
        {
            return Ok(await _order.GetByIdAsync(id));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTheOrder(int id)
        {
            return Ok(await _order.DeleteAsync(id));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTheOrder(Order order)
        {
            return Ok(await _order.UpdateAsync(order));
        }

    }
}
