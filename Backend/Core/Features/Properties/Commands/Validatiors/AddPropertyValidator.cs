using Core.Features.Properties.Commands.Models;
using Core.Resources;
using Core.Services.Abstracts;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Core.Features.Properties.Commands.Validatiors;

public class AddPropertyValidator : AbstractValidator<AddPropertyCommand>
{
    #region Fields
    private readonly IPropertyService _propertyService;
    private readonly IStringLocalizer<SharedResources> _localizer;
    //private readonly IBrokerService _brokerService;
    #endregion

    #region Constructors
    public AddPropertyValidator(IPropertyService propertyService,
                               IStringLocalizer<SharedResources> localizer)
    //IBrokerService departmentService)
    {
        _propertyService = propertyService;
        _localizer = localizer;
        ApplyValidationsRules();
        ApplyCustomValidationsRules();
        //_brokerService=departmentService;
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

        RuleFor(x => x.BrokerId)
             .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
             .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required]);
    }

    public void ApplyCustomValidationsRules()
    {
        RuleFor(x => x.NameAr)
            .MustAsync(async (Key, CancellationToken) => !await _propertyService.IsNameArExist(Key))
            .WithMessage(_localizer[SharedResourcesKeys.IsExist]);
        RuleFor(x => x.NameEn)
           .MustAsync(async (Key, CancellationToken) => !await _propertyService.IsNameEnExist(Key))
           .WithMessage(_localizer[SharedResourcesKeys.IsExist]);



        // RuleFor(x => x.BrokerId)
        //.MustAsync(async (Key, CancellationToken) => await _brokerService.IsDepartmentIdExist(Key))
        //.WithMessage(_localizer[SharedResourcesKeys.IsNotExist]);




    }

    #endregion

}
