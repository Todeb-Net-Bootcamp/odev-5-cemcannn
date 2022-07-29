using Business.Abstract;
using DTO.Customer;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;
        public CustomerController(ICustomerService service)
        {
            _service = service;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            var data = _service.GetAll();
            return Ok(data);

        }
        
        [HttpGet("GetAll2")]
        public IActionResult GetAll2()
        {
            var data = _service.GetAll2();
            return Ok(data);

        }

        [HttpPost]
        public IActionResult Post(CreateCustomerRequest customer)
        {
            var response = _service.Insert(customer);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(UpdateCustomerRequest customer)
        {
            var response = _service.Update(customer);
            return Ok(response);
        }

        [HttpDelete]
        public IActionResult Delete(Customer customer)
        {
            var response = _service.Delete(customer);
            return Ok(response);
        }
    }


}
