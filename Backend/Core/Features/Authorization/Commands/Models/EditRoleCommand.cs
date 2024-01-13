using Core.Bases;
using Core.Features.Authorization.Quaries.Results;
using MediatR;

namespace Core.Features.Authorization.Commands.Models;

public class EditRoleCommand : EditRoleRequest, IRequest<Response<string>>
{

}
