using Ejemplo.Application.Interfaces;
using Ejemplo.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Ejemplo.Application.Queries
{
    public class ConsultarEstudiantesQuery : IRequest<List<Estudiante>>
    {

    }

    public class ConsultarEstudiantesQueryHandler : IRequestHandler<ConsultarEstudiantesQuery, List<Estudiante>>
    {
        private readonly IApplicationDbContext _context;

        public ConsultarEstudiantesQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Estudiante>> Handle(ConsultarEstudiantesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Estudiantes.ToListAsync(cancellationToken);
        }
    }
}
