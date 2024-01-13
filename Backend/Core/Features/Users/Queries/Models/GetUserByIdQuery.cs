using Core.Bases;
using Core.Features.Users.Queries.Results;
using MediatR;

namespace Core.Features.Users.Queries.Models;

public class GetUserByIdQuery : IRequest<Response<GetUserByIdResponse>>
{
    public int Id { get; set; }
    public GetUserByIdQuery(int id)
    {
        Id = id;
    }
}
