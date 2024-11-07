using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderMicroservice.ApplicationCore.Contracts.IRepositories;
using OrderMicroservice.ApplicationCore.Entities;
using OrderMicroservice.Infrastructure.Repositories;

namespace OrderMicroservice.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepositoryAsync _repo;
        public PaymentController(IPaymentRepositoryAsync paymentRepositoryAsync)
        {
            _repo = paymentRepositoryAsync;
        }

        [HttpGet]
        public async Task<IActionResult> GetPaymentByCustomerId(int id)
        {
            return Ok(await _repo.GetByCustomerIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> SavePayment(Payment_Method payment)
        {
            return Ok(await _repo.InsertAsync(payment));
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePayment(int id)
        {
            return Ok(await _repo.DeleteAsync(id)); 
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePayment(Payment_Method payment)
        {
            return Ok(await _repo.UpdateAsync(payment));
        }
    }
}
