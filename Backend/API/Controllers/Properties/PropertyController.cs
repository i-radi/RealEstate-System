using API.Base;
using Core.Features.Properties.Commands.Models;
using Core.Features.Properties.Queries.Models;
using Core.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Properties;

[ApiController]
[Authorize(Roles = "Admin,User")]
public class PropertyController : AppControllerBase
{
    [HttpGet(Router.PropertyRouting.List)]
    [Authorize(Roles = "User")]
    [ServiceFilter(typeof(AuthFilter))]
    public async Task<IActionResult> GetPropertyList()
    {
        var response = await Mediator.Send(new GetPropertyListQuery());
        return NewResult(response);
    }
    [AllowAnonymous]
    [HttpGet(Router.PropertyRouting.Paginated)]
    public async Task<IActionResult> Paginated([FromQuery] GetPropertyPaginatedListQuery query)
    {
        var response = await Mediator.Send(query);
        return Ok(response);
    }
    [HttpGet(Router.PropertyRouting.GetByID)]
    public async Task<IActionResult> GetPropertyByID([FromRoute] int id)
    {
        return NewResult(await Mediator.Send(new GetPropertyByIdQuery(id)));
    }
    [Authorize(Policy = "CreateProperty")]
    [HttpPost(Router.PropertyRouting.Create)]
    public async Task<IActionResult> Create([FromBody] AddPropertyCommand command)
    {
        var response = await Mediator.Send(command);
        return NewResult(response);
    }
    [Authorize(Policy = "EditProperty")]
    [HttpPut(Router.PropertyRouting.Edit)]
    public async Task<IActionResult> Edit([FromBody] EditPropertyCommand command)
    {
        var response = await Mediator.Send(command);
        return NewResult(response);
    }
    [Authorize(Policy = "DeleteProperty")]
    [HttpDelete(Router.PropertyRouting.Delete)]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        return NewResult(await Mediator.Send(new DeletePropertyCommand(id)));
    }
}
