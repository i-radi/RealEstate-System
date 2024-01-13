using Core.Features.Properties.Commands.Models;
using Core.Resources;
using Core.Services.Abstracts;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Core.Features.Properties.Commands.Validatiors;

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
