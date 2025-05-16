using Microsoft.AspNetCore.Mvc;
using MediatR;
using BudgetFlow.Application.Users.Commands;
using Microsoft.AspNetCore.Authorization;
using Azure;

namespace BudgetFlow.Api.Contr
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserCommand command)
        {
            var response = await _mediator.Send(command);

            if (!response.Success)
                return BadRequest(response);

            return Ok(response);
        }

        //[HttpPost("login")]
        //public async Task<IActionResult> Login([FromBody] LoginUserCommand command)
        //{
        //    var result = await _mediator.Send(command);
        //    return Ok(result);
        //}
    }
}
