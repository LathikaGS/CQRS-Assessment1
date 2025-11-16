using CQRS.Command.UpdateStudent;
using FluentValidation;

namespace CQRS.Commands.UpdateStudent
{
    public class UpdateStudentValidator : AbstractValidator<UpdateStudentCommand>
    {
        public UpdateStudentValidator()
        {

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Student name is required.")
                .MinimumLength(3).WithMessage("Student name must be at least 3 characters long.");

            RuleFor(x => x.Age)
                .GreaterThan(17).WithMessage("Age must be greater than seventeen.");
        }
    }
}
