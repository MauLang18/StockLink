using MediatR;
using Microsoft.AspNetCore.Mvc;
using StockLink.Application.UseCase.UseCase.Familias.Queries.GetAll;

namespace StockLink.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamiliasController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FamiliasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ListFamilias()
        {
            var response = await _mediator.Send(new GetAllFamiliasQuery());

            return Ok(response);
        }
    }
}
