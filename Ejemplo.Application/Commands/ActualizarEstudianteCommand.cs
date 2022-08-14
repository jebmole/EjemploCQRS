using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo.Application.Commands
{
    public class ActualizarEstudianteCommand
    {
        public int Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Email { get; set; }

        public string Celular { get; set; }
    }
}
