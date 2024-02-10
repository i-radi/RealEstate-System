using Core.Bases;
using Core.Resources;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Core.Features.Authentication.Queries.Models;

public class ConfirmResetPasswordQuery : IRequest<Response<string>>
{
    public string Code { get; set; }
    public string Email { get; set; }
}

public class ConfirmResetPasswordQueryValidator : AbstractValidator<ConfirmResetPasswordQuery>
{
    #region Fields
    private readonly IStringLocalizer<SharedResources> _localizer;
    #endregion

    #region Constructors
    public ConfirmResetPasswordQueryValidator(IStringLocalizer<SharedResources> localizer)
    {
        _localizer = localizer;
        ApplyValidationsRules();
        ApplyCustomValidationsRules();
    }
    #endregion

    #region Actions
    public void ApplyValidationsRules()
    {
        RuleFor(x => x.Code)
             .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
             .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required]);
        RuleFor(x => x.Email)
             .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
             .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required]);

    }

    public void ApplyCustomValidationsRules()
    {
    }

    #endregion
}