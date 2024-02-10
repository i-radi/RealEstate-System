using Core.Bases;
using Core.Resources;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Core.Features.Authentication.Queries.Models;

public class ConfirmEmailQuery : IRequest<Response<string>>
{
    public int UserId { get; set; }
    public string Code { get; set; }
}

public class ConfirmEmailValidator : AbstractValidator<ConfirmEmailQuery>
{
    #region Fields
    private readonly IStringLocalizer<SharedResources> _localizer;
    #endregion

    #region Constructors
    public ConfirmEmailValidator(IStringLocalizer<SharedResources> localizer)
    {
        _localizer = localizer;
        ApplyValidationsRules();
        ApplyCustomValidationsRules();
    }
    #endregion

    #region Actions
    public void ApplyValidationsRules()
    {
        RuleFor(x => x.UserId)
             .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
             .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required]);

        RuleFor(x => x.Code)
            .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
            .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required]);
    }

    public void ApplyCustomValidationsRules()
    {
    }

    #endregion

}