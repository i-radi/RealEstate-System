using Core.Bases;
using Core.Features.Authorization.Quaries.Results;
using MediatR;

namespace Core.Features.Authorization.Commands.Models;

public class UpdateUserRolesCommand : UpdateUserRolesRequest, IRequest<Response<string>>
{
}
