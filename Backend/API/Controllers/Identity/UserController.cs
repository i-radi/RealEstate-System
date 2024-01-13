using API.Base;
using Core.Features.Users.Commands.Models;
using Core.Features.Users.Queries.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers.Identity;

[ApiController]
[Authorize(Roles = "Admin,User")]
public class UserController : AppControllerBase
{
    [HttpPost(Router.UserRouting.Create)]
    public async Task<IActionResult> Create([FromBody] AddUserCommand command)
    {
        var response = await Mediator.Send(command);
        return NewResult(response);
    }
    [HttpGet(Router.UserRouting.Paginated)]
    public async Task<IActionResult> Paginated([FromQuery] GetUserPaginationQuery query)
    {
        var response = await Mediator.Send(query);
        return Ok(response);
    }
    [HttpGet(Router.UserRouting.GetByID)]
    public async Task<IActionResult> GetPropertyByID([FromRoute] int id)
    {
        return NewResult(await Mediator.Send(new GetUserByIdQuery(id)));
    }
    [HttpPut(Router.UserRouting.Edit)]
    public async Task<IActionResult> Edit([FromBody] EditUserCommand command)
    {
        var response = await Mediator.Send(command);
        return NewResult(response);
    }
    [HttpDelete(Router.UserRouting.Delete)]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        return NewResult(await Mediator.Send(new DeleteUserCommand(id)));
    }
    [HttpPut(Router.UserRouting.ChangePassword)]
    public async Task<IActionResult> ChangePassword([FromBody] ChangeUserPasswordCommand command)
    {
        var response = await Mediator.Send(command);
        return NewResult(response);
    }
}
