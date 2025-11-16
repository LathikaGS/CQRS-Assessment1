using CQRS.Models;
using MediatR;


namespace CQRS.Command.UpdateStudent
{
    public record  UpdateStudentCommand(int Id, string Name, string Email, int Age) : IRequest<bool>;
}
