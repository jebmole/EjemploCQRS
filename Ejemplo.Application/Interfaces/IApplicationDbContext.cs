using Ejemplo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ejemplo.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Estudiante> Estudiantes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
