using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // Attribute, In Java we call it Annotation
    public class ColorsController : ControllerBase
    {
        // Loosely Coupled
        // IoC Container - Inversion of Control
        IColorService _iColorService;
        public ColorsController(IColorService iColorService)
        {
            _iColorService = iColorService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _iColorService.GetAll();
            if (!result.IsSuccess)
                return NotFound(result);
            return Ok(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int productId)
        {
            var result = _iColorService.GetColorById(productId);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Color color)
        {
            var result = _iColorService.Add(color);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Color color)
        {
            var result = _iColorService.Update(color);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Color color)
        {
            var result = _iColorService.Delete(color);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
    }
}
