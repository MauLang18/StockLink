using Microsoft.AspNetCore.Mvc;
using StockLink.Application._6.Dtos.Rol.Request;
using StockLink.Application._6.Dtos.Usuario.Request;
using StockLink.Application._6.Interfaces;
using StockLink.Application._6.Services;
using StockLink.Infrastructure._6.Commons.Bases.Request;

namespace StockLink.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly IRolApplication _rolApplication;

        public RolController(IRolApplication rolApplication)
        {
            _rolApplication = rolApplication;
        }

        [HttpGet]
        public async Task<IActionResult> ListUsuarios([FromQuery] BaseFiltersRequest filters)
        {
            var response = await _rolApplication.ListRoles(filters);
            return Ok(response);
        }

        [HttpGet("Select")]
        public async Task<IActionResult> ListSelectRoles()
        {
            var response = await _rolApplication.ListSelectRol();

            return Ok(response);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> RolById(int id)
        {
            var response = await _rolApplication.RolById(id);

            return Ok(response);
        }

        [HttpPost("Register")]
        public async Task<IActionResult> RegisterRol([FromBody] RolRequestDto requestDto)
        {
            var response = await _rolApplication.RegisterRol(requestDto);

            return Ok(response);
        }

        [HttpPut("Edit/{id:int}")]
        public async Task<IActionResult> EditRol(int id, [FromBody] RolRequestDto requestDto)
        {
            var response = await _rolApplication.EditRol(id, requestDto);

            return Ok(response);
        }

        [HttpDelete("Remove/{id:int}")]
        public async Task<IActionResult> RemoveRol(int id)
        {
            var response = await _rolApplication.RemoveRol(id);

            return Ok(response);
        }
    }
}
