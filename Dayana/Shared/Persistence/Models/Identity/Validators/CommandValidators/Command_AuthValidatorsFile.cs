﻿using Dayana.Shared.Infrastructure.Errors.Identity;
using Dayana.Shared.Persistence.Models.Identity.Commands.Auth;
using FluentValidation;

namespace Dayana.Shared.Persistence.Models.Identity.Validators.CommandValidators;


public class LoginCommandValidator : AbstractValidator<LoginCommand>
{
    public LoginCommandValidator()
    {
        RuleFor(x => x.UserName)
            .NotEmpty()
            .When(x => string.IsNullOrEmpty(x.Email))
            .WithState(_ => UserErrors.InvalidEmailValidationError);

        RuleFor(x => x.UserName)
            .EmailAddress()
            .When(x => string.IsNullOrEmpty(x.UserName))
            .WithState(_ => UserErrors.InvalidUsernameValidationError);

        RuleFor(x => x.Password)
            .NotEmpty()
            .WithState(_ => UserErrors.InvalidPasswordValidationError);
    }
}


