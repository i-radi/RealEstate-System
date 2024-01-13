using Core.Bases;
using Data.Results;
using MediatR;

namespace Core.Features.Authorization.Quaries.Models;

public class ManageUserRolesQuery : IRequest<Response<ManageUserRolesResult>>
{
    public int UserId { get; set; }
}
