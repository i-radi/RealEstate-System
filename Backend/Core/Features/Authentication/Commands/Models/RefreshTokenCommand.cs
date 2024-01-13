using Core.Bases;
using Core.Features.Authentication.Queries.Results;
using MediatR;

namespace Core.Features.Authentication.Commands.Models;

public class RefreshTokenCommand : IRequest<Response<JwtAuthResult>>
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }
}
