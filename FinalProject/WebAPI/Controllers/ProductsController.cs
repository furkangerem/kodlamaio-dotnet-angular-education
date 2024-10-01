using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // Attribute, In Java we call it Annotation
    public class ProductsController : ControllerBase
    {
        // Loosely Coupled
        // IoC Container - Inversion of Control
        IProductService _iProductService;

        public ProductsController(IProductService iProductService)
        {
            _iProductService = iProductService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _iProductService.GetAll();
            if (!result.IsSuccess)
                return NotFound(result);

            return Ok(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int productId)
        {
            var result = _iProductService.GetById(productId);
            if (!result.IsSuccess)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _iProductService.Add(product);
            if (!result.IsSuccess)
                return BadRequest(result);

            return Ok(result);
        }
    }
}
