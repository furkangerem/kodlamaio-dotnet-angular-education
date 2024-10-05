using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] // Attribute, In Java we call it Annotation
    public class UsersController : ControllerBase
    {
        // Loosely Coupled
        // IoC Container - Inversion of Control
        IUserService _iUserService;
        public UsersController(IUserService iUserService)
        {
            _iUserService = iUserService;
        }

        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _iUserService.GetAll();
            if (!result.IsSuccess)
                return NotFound(result);
            return Ok(result);
        }

        [HttpGet("getById")]
        public IActionResult GetById(int productId)
        {
            var result = _iUserService.GetUserById(productId);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var result = _iUserService.Add(user);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("update")]
        public IActionResult Update(User user)
        {
            var result = _iUserService.Update(user);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(User user)
        {
            var result = _iUserService.Delete(user);
            if (!result.IsSuccess)
                return BadRequest(result);
            return Ok(result);
        }
    }
}
