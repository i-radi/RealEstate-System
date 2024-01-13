using Core.Bases;
using Core.Features.Properties.Queries.Results;
using MediatR;

namespace Core.Features.Properties.Queries.Models;

public class GetPropertyListQuery : IRequest<Response<List<GetPropertyListResponse>>>
{
}
