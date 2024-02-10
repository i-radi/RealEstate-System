using AutoMapper;
using Core.Bases;
using Core.Resources;
using Core.Services.Abstracts;
using Data.Entities.Properties;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Core.Features.Properties.Commands.Models;

public class EditPropertyCommand : IRequest<Response<string>>, ICustomMapping
{
    public int Id { get; set; }
    public string NameAr { get; set; }
    public string NameEn { get; set; }
    public string Address { get; set; }
    public string? Phone { get; set; }
    public int BrokerId { get; set; }

    public void CreateMappings(Profile configuration)
    {
        configuration.CreateMap<EditPropertyCommand, Property>()
                   .ForMember(dest => dest.BrokerId, opt => opt.MapFrom(src => src.BrokerId))
                   .ForMember(dest => dest.NameEn, opt => opt.MapFrom(src => src.NameEn))
                   .ForMember(dest => dest.NameAr, opt => opt.MapFrom(src => src.NameAr));
    }
}

public class EditPropertyValidator : AbstractValidator<EditPropertyCommand>
{
    #region Fields
    private readonly IPropertyService _propertyService;
    private readonly IStringLocalizer<SharedResources> _localizer;
    #endregion

    #region Constructors
    public EditPropertyValidator(IPropertyService propertyService,
                                IStringLocalizer<SharedResources> localizer)
    {
        _propertyService = propertyService;
        _localizer = localizer;
        ApplyValidationsRules();
        ApplyCustomValidationsRules();
    }
    #endregion

    #region Actions
    public void ApplyValidationsRules()
    {
        RuleFor(x => x.NameAr)
             .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
             .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required])
             .MaximumLength(100).WithMessage(_localizer[SharedResourcesKeys.MaxLengthis100]);

        RuleFor(x => x.Address)
            .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
            .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required])
            .MaximumLength(100).WithMessage(_localizer[SharedResourcesKeys.MaxLengthis100]);
    }

    public void ApplyCustomValidationsRules()
    {
        RuleFor(x => x.NameAr)
            .MustAsync(async (model, Key, CancellationToken) => !await _propertyService.IsNameArExistExcludeSelf(Key, model.Id))
            .WithMessage(_localizer[SharedResourcesKeys.IsExist]);
        RuleFor(x => x.NameEn)
            .MustAsync(async (model, Key, CancellationToken) => !await _propertyService.IsNameEnExistExcludeSelf(Key, model.Id))
            .WithMessage(_localizer[SharedResourcesKeys.IsExist]);
    }

    #endregion
}