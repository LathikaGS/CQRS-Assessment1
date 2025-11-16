using MediatR;

namespace CQRS.Command.DeleteStudent
{
    public record class DeleteStudentCommand(int Id) : IRequest<bool>;
}
