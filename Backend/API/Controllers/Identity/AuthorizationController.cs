﻿using API.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers.Identity;

[ApiController]
[Authorize(Roles = "Admin")]
public class AuthorizationController : AppControllerBase
{
    //[HttpPost(Router.AuthorizationRouting.Create)]
    //public async Task<IActionResult> Create([FromForm] AddRoleCommand command)
    //{
    //    var response = await Mediator.Send(command);
    //    return NewResult(response);
    //}
    //[HttpPost(Router.AuthorizationRouting.Edit)]
    //public async Task<IActionResult> Edit([FromForm] EditRoleCommand command)
    //{
    //    var response = await Mediator.Send(command);
    //    return NewResult(response);
    //}
    //[HttpDelete(Router.AuthorizationRouting.Delete)]
    //public async Task<IActionResult> Delete([FromRoute] int id)
    //{
    //    var response = await Mediator.Send(new DeleteRoleCommand(id));
    //    return NewResult(response);
    //}
    //[HttpGet(Router.AuthorizationRouting.RoleList)]
    //public async Task<IActionResult> GetRoleList()
    //{
    //    var response = await Mediator.Send(new GetRolesListQuery());
    //    return NewResult(response);
    //}
    //[SwaggerOperation(Summary = "idالصلاحية عن طريق ال", OperationId = "RoleById")]
    //[HttpGet(Router.AuthorizationRouting.GetRoleById)]
    //public async Task<IActionResult> GetRoleById([FromRoute] int id)
    //{
    //    var response = await Mediator.Send(new GetRoleByIdQuery() { Id = id });
    //    return NewResult(response);
    //}
    //[SwaggerOperation(Summary = " ادارة صلاحيات المستخدمين", OperationId = "ManageUserRoles")]
    //[HttpGet(Router.AuthorizationRouting.ManageUserRoles)]
    //public async Task<IActionResult> ManageUserRoles([FromRoute] int userId)
    //{
    //    var response = await Mediator.Send(new ManageUserRolesQuery() { UserId = userId });
    //    return NewResult(response);
    //}
    //[SwaggerOperation(Summary = " تعديل صلاحيات المستخدمين", OperationId = "UpdateUserRoles")]
    //[HttpPut(Router.AuthorizationRouting.UpdateUserRoles)]
    //public async Task<IActionResult> UpdateUserRoles([FromBody] UpdateUserRolesCommand command)
    //{
    //    var response = await Mediator.Send(command);
    //    return NewResult(response);
    //}
}
