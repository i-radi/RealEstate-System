using Core.Features.Users.Queries.Results;
using Core.Wrappers;
using MediatR;

namespace Core.Features.Users.Queries.Models;

public class GetUserPaginationQuery : IRequest<PaginatedResult<GetUserPaginationReponse>>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}
