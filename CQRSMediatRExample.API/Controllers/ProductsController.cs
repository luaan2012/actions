using CQRSMediatRExample.API.Command.AddProduct;
using CQRSMediatRExample.API.Command.ListProduct;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace CQRSMediatRExample.API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpPost("Post1")]
        public async Task<IActionResult> Post(AddProductCommand command)
        {
            throw new InvalidDataException("teste");

            await _mediator.Send(command);

            return Ok();
        }

        [HttpPost("Post2")]
        public async Task<IActionResult> Post(AddProductWithResultCommand command)
        {
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpPost("Get")]
        public async Task<IActionResult> Get(ListProductCommand command)
        {           
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}
