using System;

namespace BibliotecaML.EN
{
    public class Estudiante
    {
        public int IdEstudiante { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;

        public string Documento { get; set; } = string.Empty;

        public string Carnet { get; set; } = string.Empty;

        public string Carrera { get; set; } = string.Empty;

        public string Correo { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;

        public bool Estado { get; set; }
    }
}
