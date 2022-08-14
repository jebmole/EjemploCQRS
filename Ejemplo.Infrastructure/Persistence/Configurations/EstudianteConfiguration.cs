using Ejemplo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ejemplo.Infrastructure.Persistence.Configurations
{
    public class EstudianteConfiguration : IEntityTypeConfiguration<Estudiante>
    {
        public void Configure(EntityTypeBuilder<Estudiante> builder)
        {
            builder.ToTable("Estudiante");

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Celular)
                .HasMaxLength(12)
                .IsUnicode(false);

            builder.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.FechaNacimiento).HasColumnType("date");

            builder.Property(e => e.Nombres)
                .HasMaxLength(50)
                .IsUnicode(false);
        }
    }
}
