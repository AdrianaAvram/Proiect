using FluentValidation;
using Proiect.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proiect.Validator
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.UserName).NotNull().WithMessage("Numele de utilizator trebuie completat!");
            RuleFor(x => x.Name).NotNull().WithMessage("Numele trebuie completat!");
            RuleFor(x => x.Age).NotNull().WithMessage("Campul nu poate fi gol!");
            RuleFor(x => x.Password).NotNull().WithMessage("Completeaza!");
            RuleFor(x => x.ConfirmPassword).NotNull().Equal(x => x.Password).WithMessage("Parola trebuie sa fie aceeasi");

        }

      
    }
    
}
