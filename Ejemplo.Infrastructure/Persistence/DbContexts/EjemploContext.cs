using System;
using System.Collections.Generic;
using Ejemplo.Application.Interfaces;
using Ejemplo.Domain.Entities;
using Ejemplo.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ejemplo.Infrastructure.Persistence.DbContexts
{
    public partial class EjemploContext : DbContext, IApplicationDbContext
    {
        public EjemploContext()
        {
        }

        public EjemploContext(DbContextOptions<EjemploContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Estudiante> Estudiantes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EstudianteConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
