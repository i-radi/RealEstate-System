using Core.Bases;
using Core.Features.Properties.Queries.Results;
using MediatR;

namespace Core.Features.Properties.Queries.Models;

public class GetPropertyByIdQuery : IRequest<Response<GetSinglePropertyResponse>>
{
    public int Id { get; set; }
    public GetPropertyByIdQuery(int id)
    {
        Id = id;
    }
}
