using Core.Bases;
using Core.Features.Authorization.Quaries.Results;
using Core.Resources;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Core.Features.Authorization.Commands.Models;

public class EditRoleCommand : EditRoleRequest, IRequest<Response<string>>
{

}

public class EditRoleValidator : AbstractValidator<EditRoleCommand>
{
    #region Fields
    private readonly IStringLocalizer<SharedResources> _stringLocalizer;
    #endregion
    #region Constructors

    #endregion
    public EditRoleValidator(IStringLocalizer<SharedResources> stringLocalizer)
    {
        _stringLocalizer = stringLocalizer;
        ApplyValidationsRules();
        ApplyCustomValidationsRules();
    }

    #region Actions
    public void ApplyValidationsRules()
    {
        RuleFor(x => x.Id)
             .NotEmpty().WithMessage(_stringLocalizer[SharedResourcesKeys.NotEmpty])
             .NotNull().WithMessage(_stringLocalizer[SharedResourcesKeys.Required]);

        RuleFor(x => x.Name)
             .NotEmpty().WithMessage(_stringLocalizer[SharedResourcesKeys.NotEmpty])
             .NotNull().WithMessage(_stringLocalizer[SharedResourcesKeys.Required]);
    }

    public void ApplyCustomValidationsRules()
    {

    }

    #endregion
}
