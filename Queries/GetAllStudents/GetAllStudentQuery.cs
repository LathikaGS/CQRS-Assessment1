using MediatR;
using CQRS.Models;

namespace CQRS.Queries.GetAllStudents
{
    public record GetAllStudentQuery() : IRequest<List<Student>>;
}
