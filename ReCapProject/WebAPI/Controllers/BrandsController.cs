using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // Attribute, In Java we call it Annotation
    public class BrandsController : ControllerBase
    {
        // Loosely Coupled
        // IoC Container - Inversion of Control
        IBrandService _iBrandService;
        public BrandsController(IBrandService brandService)
        {
            _iBrandService = brandService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _iBrandService.GetAll();
            if (!result.IsSuccess)
                return NotFound(result);
            return Ok(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int productId)
        {
            var result = _iBrandService.GetBrandById(productId);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {
            var result = _iBrandService.Add(brand);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Brand brand)
        {
            var result = _iBrandService.Update(brand);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Brand brand)
        {
            var result = _iBrandService.Delete(brand);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
    }
}
