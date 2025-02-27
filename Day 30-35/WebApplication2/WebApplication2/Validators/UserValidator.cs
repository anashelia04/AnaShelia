using FluentValidation;
using WebApplication2.Model;

namespace WebApplication2.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("First name is required.");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("Last name is required.");
            RuleFor(u => u.Email).NotEmpty().EmailAddress().WithMessage("Email must be valid.");
            RuleFor(u => u.Age).InclusiveBetween(18, 120).WithMessage("Age must be between 18 and 120.");
        }
    }

}
