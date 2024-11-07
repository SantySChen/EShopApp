using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderMicroservice.ApplicationCore.Contracts.IRepositories;
using OrderMicroservice.ApplicationCore.Entities;
using OrderMicroservice.Infrastructure.Repositories;

namespace OrderMicroservice.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepositoryAsync _repo;
        public CustomerController(ICustomerRepositoryAsync customerRepositoryAsync)
        {
            _repo = customerRepositoryAsync;
        }
        [HttpGet]
        public async Task<IActionResult> GetCustomerAddressByUserId(int id)
        {
            return Ok(await _repo.GetAddressById(id));
        }

        [HttpPost]
        public async Task<IActionResult> SaveCustomerAddress(Address address)
        {
            return Ok(await _repo.SaveCustomerAddress(address));
        }
    }
}
