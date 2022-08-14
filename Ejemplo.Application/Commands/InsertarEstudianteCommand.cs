using Ejemplo.Application.Interfaces;
using Ejemplo.Domain.Entities;
using MediatR;

namespace Ejemplo.Application.Commands
{
    public class InsertarEstudianteCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Email { get; set; }

        public string Celular { get; set; }

        public bool Activo { get; set; }
    }

    public class InsertarEstudianteCommandHandler : IRequestHandler<InsertarEstudianteCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public InsertarEstudianteCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(InsertarEstudianteCommand request, CancellationToken cancellationToken)
        {
            var estudiante = new Estudiante
            {
                Activo = request.Activo,
                Apellidos = request.Apellidos,
                Celular = request.Celular,
                Email = request.Email,
                FechaNacimiento = request.FechaNacimiento,
                Id = request.Id,
                Nombres = request.Nombres,
            };

            await _context.Estudiantes.AddAsync(estudiante, cancellationToken);
            var rows = await _context.SaveChangesAsync(cancellationToken);

            return rows > 0;
        }
    }
}
