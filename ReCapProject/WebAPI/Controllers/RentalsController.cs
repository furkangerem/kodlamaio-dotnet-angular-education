using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // Attribute, In Java we call it Annotation
    public class RentalsController : ControllerBase
    {
        // Loosely Coupled
        // IoC Container - Inversion of Control
        IRentalService _iRentalService;
        public RentalsController(IRentalService iRentalService)
        {
            _iRentalService = iRentalService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _iRentalService.GetAll();
            if (!result.IsSuccess)
                return NotFound(result);
            return Ok(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int productId)
        {
            var result = _iRentalService.GetRentalById(productId);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            var result = _iRentalService.Add(rental);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Rental rental)
        {
            var result = _iRentalService.Update(rental);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Rental rental)
        {
            var result = _iRentalService.Delete(rental);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
    }
}
