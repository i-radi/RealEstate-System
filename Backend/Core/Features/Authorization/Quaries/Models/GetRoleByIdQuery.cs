using Core.Bases;
using Core.Features.Authorization.Quaries.Results;
using MediatR;

namespace Core.Features.Authorization.Quaries.Models;

public class GetRoleByIdQuery : IRequest<Response<GetRoleByIdResult>>
{
    public int Id { get; set; }
}
