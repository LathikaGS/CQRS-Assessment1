using CQRS.Data;
using CQRS.Models;
using CQRS.Queries.GetAllStudents;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Query.GetAllStudents
{
    public class GetAllStudentsHandler : IRequestHandler<GetAllStudentQuery, List<Student>>
    {
        private readonly AppDbContext _context;

        public GetAllStudentsHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            return await _context.Students.ToListAsync(cancellationToken);
        }
    }
}
