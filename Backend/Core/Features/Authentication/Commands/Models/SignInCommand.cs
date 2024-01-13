
using Core.Bases;
using Core.Features.Authentication.Queries.Results;
using MediatR;

namespace Core.Features.Authentication.Commands.Models;

public class SignInCommand : IRequest<Response<JwtAuthResult>>
{
    public string UserName { get; set; }
    public string Password { get; set; }
}
