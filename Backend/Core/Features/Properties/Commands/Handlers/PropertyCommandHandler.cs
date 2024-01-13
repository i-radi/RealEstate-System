using AutoMapper;
using Core.Bases;
using Core.Features.Properties.Commands.Models;
using Core.Resources;
using Core.Services.Abstracts;
using Data.Entities.Properties;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Core.Features.Properties.Commands.Handlers;

public class PropertyCommandHandler : ResponseHandler,
                                   IRequestHandler<AddPropertyCommand, Response<string>>,
                                   IRequestHandler<EditPropertyCommand, Response<string>>,
                                   IRequestHandler<DeletePropertyCommand, Response<string>>
{
    #region Fields
    private readonly IPropertyService _propertyService;
    private readonly IMapper _mapper;
    private readonly IStringLocalizer<SharedResources> _localizer;
    #endregion

    #region Constructors
    public PropertyCommandHandler(IPropertyService propertyService,
                                 IMapper mapper,
                                 IStringLocalizer<SharedResources> localizer) : base(localizer)
    {
        _propertyService = propertyService;
        _mapper = mapper;
        _localizer = localizer;
    }
    #endregion


    #region Handle Functions

    public async Task<Response<string>> Handle(AddPropertyCommand request, CancellationToken cancellationToken)
    {
        //mapping Between request and property
        var propertymapper = _mapper.Map<Property>(request);
        //add
        var result = await _propertyService.AddAsync(propertymapper);
        //return response
        if (result == "Success") return Created("");
        else return BadRequest<string>();
    }

    public async Task<Response<string>> Handle(EditPropertyCommand request, CancellationToken cancellationToken)
    {
        //Check if the Id is Exist Or not
        var property = await _propertyService.GetByIDAsync(request.Id);
        //return NotFound
        if (property == null) return NotFound<string>();
        //mapping Between request and property
        var propertymapper = _mapper.Map(request, property);
        //Call service that make Edit
        var result = await _propertyService.EditAsync(propertymapper);
        //return response
        if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Updated]);
        else return BadRequest<string>();
    }

    public async Task<Response<string>> Handle(DeletePropertyCommand request, CancellationToken cancellationToken)
    {
        //Check if the Id is Exist Or not
        var property = await _propertyService.GetByIDAsync(request.Id);
        //return NotFound
        if (property == null) return NotFound<string>();
        //Call service that make Delete
        property.IsDeleted = true;
        property.DeletedDate = DateTime.Now;
        var result = await _propertyService.EditAsync(property);
        if (result == "Success") return Deleted<string>();
        else return BadRequest<string>();
    }
    #endregion

}
