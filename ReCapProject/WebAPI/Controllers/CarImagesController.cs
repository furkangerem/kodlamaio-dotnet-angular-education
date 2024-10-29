using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // Attribute, In Java we call it Annotation
    public class CarImagesController : ControllerBase
    {
        // Loosely Coupled
        // IoC Container - Inversion of Control
        ICarImageService _iCarImageService;
        public CarImagesController(ICarImageService iCarImageService)
        {
            _iCarImageService = iCarImageService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _iCarImageService.GetAll();
            if (!result.IsSuccess)
                return NotFound(result);
            return Ok(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int carImageId)
        {
            var result = _iCarImageService.GetCarImageById(carImageId);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] IFormFile iFormFile, [FromForm] CarImage carImage)
        {
            var result = _iCarImageService.Add(iFormFile, carImage);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm] IFormFile iFormFile, [FromForm] CarImage carImage)
        {
            var result = _iCarImageService.Update(iFormFile, carImage);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            var result = _iCarImageService.Delete(carImage);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
    }
}
