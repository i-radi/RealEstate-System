using Core.Bases;
using MediatR;

namespace Core.Features.Authentication.Queries.Models;

public class AuthorizeUserQuery : IRequest<Response<string>>
{
    public string AccessToken { get; set; }
}
