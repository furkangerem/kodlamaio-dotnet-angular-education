using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // Attribute, In Java we call it Annotation
    public class CustomersController : ControllerBase
    {
        // Loosely Coupled
        // IoC Container - Inversion of Control
        ICustomerService _iCustomerService;
        public CustomersController(ICustomerService iCustomerService)
        {
            _iCustomerService = iCustomerService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _iCustomerService.GetAll();
            if (!result.IsSuccess)
                return NotFound(result);
            return Ok(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int productId)
        {
            var result = _iCustomerService.GetCustomerById(productId);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            var result = _iCustomerService.Add(customer);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Customer customer)
        {
            var result = _iCustomerService.Update(customer);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Customer customer)
        {
            var result = _iCustomerService.Delete(customer);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
    }
}
