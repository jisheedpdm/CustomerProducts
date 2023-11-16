using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.InfraStructure.Respository;
using ProductAPI.Service.ViewModels;

namespace ProductAPI.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepo _customerRepo;
        public CustomerController(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        [HttpPost("GetCustomerOrder")]
        public async Task<IActionResult> GetCustomerOrder([FromBody] CustomerModel customer)
        {
            try
            {
                var customerOrder = await _customerRepo.GetCustomerOrder(customer.User, customer.CustomerId);
                if(customerOrder == null)
                {
                    return NotFound("User Not Found");
                }
                return Ok(customerOrder);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
