using CQRS.Data;
using CQRS.Models;
using MediatR;

namespace CQRS.Command.UpdateStudent
{
    public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, bool>
    {
        private readonly AppDbContext _context;

        public UpdateStudentHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var student = await _context.Students.FindAsync(new object[] { request.Id }, cancellationToken);

            if (student == null)
            {
                return false; 
            }

            student.Name = request.Name;
            student.Email = request.Email;
            student.Age = request.Age;

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
