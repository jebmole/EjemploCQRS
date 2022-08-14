namespace Ejemplo.Domain.Entities
{
    public class Estudiante
    {
        public int Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Email { get; set; }

        public string Celular { get; set; }

        public bool Activo { get; set; }
    }
}
