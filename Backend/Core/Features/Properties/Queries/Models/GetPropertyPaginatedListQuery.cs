using Core.Features.Properties.Queries.Results;
using Core.Wrappers;
using MediatR;

namespace Core.Features.Properties.Queries.Models;

public class GetPropertyPaginatedListQuery : IRequest<PaginatedResult<GetPropertyPaginatedListResponse>>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public string? Search { get; set; }
}
