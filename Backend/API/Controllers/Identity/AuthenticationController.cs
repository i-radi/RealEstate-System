using API.Base;
using Core.Features.Authentication.Commands.Models;
using Core.Features.Authentication.Queries.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Identity;


[ApiController]

public class AuthenticationController : AppControllerBase
{

    [HttpPost(Router.AuthenticationRouting.SignIn)]
    public async Task<IActionResult> Create([FromForm] SignInCommand command)
    {
        var response = await Mediator.Send(command);
        return NewResult(response);
    }

    [HttpPost(Router.AuthenticationRouting.RefreshToken)]
    public async Task<IActionResult> RefreshToken([FromForm] RefreshTokenCommand command)
    {
        var response = await Mediator.Send(command);
        return NewResult(response);
    }
    [HttpGet(Router.AuthenticationRouting.ValidateToken)]
    public async Task<IActionResult> ValidateToken([FromQuery] AuthorizeUserQuery query)
    {
        var response = await Mediator.Send(query);
        return NewResult(response);
    }
    [HttpGet(Router.AuthenticationRouting.ConfirmEmail)]
    public async Task<IActionResult> ConfirmEmail([FromQuery] ConfirmEmailQuery query)
    {
        var response = await Mediator.Send(query);
        return NewResult(response);
    }
    [HttpPost(Router.AuthenticationRouting.SendResetPasswordCode)]
    public async Task<IActionResult> SendResetPassword([FromQuery] SendResetPasswordCommand command)
    {
        var response = await Mediator.Send(command);
        return NewResult(response);
    }
    [HttpGet(Router.AuthenticationRouting.ConfirmResetPasswordCode)]
    public async Task<IActionResult> ConfirmResetPassword([FromQuery] ConfirmResetPasswordQuery query)
    {
        var response = await Mediator.Send(query);
        return NewResult(response);
    }
    [HttpPost(Router.AuthenticationRouting.ResetPassword)]
    public async Task<IActionResult> ResetPassword([FromForm] ResetPasswordCommand command)
    {
        var response = await Mediator.Send(command);
        return NewResult(response);
    }
}
