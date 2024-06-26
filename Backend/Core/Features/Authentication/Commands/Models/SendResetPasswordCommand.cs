﻿using Core.Bases;
using Core.Resources;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.Localization;

namespace Core.Features.Authentication.Commands.Models;

public class SendResetPasswordCommand : IRequest<Response<string>>
{
    public string Email { get; set; }
}

public class SendResetPasswordCommandValidator : AbstractValidator<SendResetPasswordCommand>
{
    #region Fields
    private readonly IStringLocalizer<SharedResources> _localizer;
    #endregion

    #region Constructors
    public SendResetPasswordCommandValidator(IStringLocalizer<SharedResources> localizer)
    {
        _localizer = localizer;
        ApplyValidationsRules();
        ApplyCustomValidationsRules();
    }
    #endregion

    #region Actions
    public void ApplyValidationsRules()
    {
        RuleFor(x => x.Email)
             .NotEmpty().WithMessage(_localizer[SharedResourcesKeys.NotEmpty])
             .NotNull().WithMessage(_localizer[SharedResourcesKeys.Required]);


    }

    public void ApplyCustomValidationsRules()
    {
    }

    #endregion

}