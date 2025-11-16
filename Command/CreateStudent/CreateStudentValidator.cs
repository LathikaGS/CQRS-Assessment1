using FluentValidation;
namespace CQRS.Command.CreateStudent
{
    public class CreateStudentValidator : AbstractValidator<CreateStudentCommand>
    {
        public CreateStudentValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Product name is required.")
                .MinimumLength(3).WithMessage("Product name must be at least 3 characters long.");

            RuleFor(x => x.Age)
                .GreaterThan(17).WithMessage("Age must be greater than seventeen.");
        }
    }
}
