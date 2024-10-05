using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // Attribute, In Java we call it Annotation
    public class CarsController : ControllerBase
    {
        // Loosely Coupled
        // IoC Container - Inversion of Control
        ICarService _iCarService;
        public CarsController(ICarService iCarService)
        {
            _iCarService = iCarService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _iCarService.GetAll();
            if (!result.IsSuccess)
                return NotFound(result);
            return Ok(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int carId)
        {
            var result = _iCarService.GetCarById(carId);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _iCarService.Add(car);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            var result = _iCarService.Update(car);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _iCarService.Delete(car);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpGet("getAllCarsByBrandId")]
        public IActionResult GetAllCarsByBrandId(int brandId)
        {
            var result = _iCarService.GetAllCarsByBrandId(brandId);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpGet("getAllCarsByColorId")]
        public IActionResult GetAllCarsByColorId(int colorId)
        {
            var result = _iCarService.GetAllCarsByColorId(colorId);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpGet("getCarDetails")]
        public IActionResult GetCarDetails()
        {
            var result = _iCarService.GetCarDetails();
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
    }
}
