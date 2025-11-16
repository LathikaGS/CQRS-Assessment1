using MediatR;
using CQRS.Models;

namespace CQRS.Command.CreateStudent
{
    public record CreateStudentCommand(int ID, string Name, string Email, int Age) : IRequest<int>;
}
