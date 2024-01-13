using AutoMapper;
using Core.Bases;
using Core.Features.Properties.Queries.Models;
using Core.Features.Properties.Queries.Results;
using Core.Resources;
using Core.Services.Abstracts;
using Core.Wrappers;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Core.Features.Properties.Queries.Handlers;

public class PropertyQueryHandler : ResponseHandler,
                                   IRequestHandler<GetPropertyByIdQuery, Response<GetSinglePropertyResponse>>,
                                   IRequestHandler<GetPropertyPaginatedListQuery, PaginatedResult<GetPropertyPaginatedListResponse>>
{

    #region Fields
    private readonly IPropertyService _propertyService;
    private readonly IMapper _mapper;
    private readonly IStringLocalizer<SharedResources> _stringLocalizer;
    #endregion
    #region Constructors
    public PropertyQueryHandler(IPropertyService propertyService,
                               IMapper mapper,
                               IStringLocalizer<SharedResources> stringLocalizer) : base(stringLocalizer)
    {
        _propertyService = propertyService;
        _mapper = mapper;
        _stringLocalizer = stringLocalizer;
    }
    #endregion


    #region Handle Functions

    public async Task<Response<GetSinglePropertyResponse>> Handle(GetPropertyByIdQuery request, CancellationToken cancellationToken)
    {
        var property = await _propertyService.GetPropertyByIDWithIncludeAsync(request.Id);
        if (property == null) return NotFound<GetSinglePropertyResponse>(_stringLocalizer[SharedResourcesKeys.NotFound]);
        var result = _mapper.Map<GetSinglePropertyResponse>(property);
        return Success(result);
    }

    public async Task<PaginatedResult<GetPropertyPaginatedListResponse>> Handle(GetPropertyPaginatedListQuery request, CancellationToken cancellationToken)
    {
        var FilterQuery = _propertyService.FilterPropertyPaginatedQuerable(request.Search);
        var PaginatedList = await _mapper.ProjectTo<GetPropertyPaginatedListResponse>(FilterQuery).ToPaginatedListAsync(request.PageNumber, request.PageSize);
        PaginatedList.Meta = new { Count = PaginatedList.Data.Count() };
        return PaginatedList;
    }

    #endregion
}
