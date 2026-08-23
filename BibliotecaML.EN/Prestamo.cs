using System;

namespace BibliotecaML.EN
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public int IdEstudiante { get; set; }
        public int IdLibro { get; set; }
        public string Estudiante { get; set; } = string.Empty;
        public string Libro { get; set; } = string.Empty;
        public string EstadoLibro { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucionEsperada { get; set; }
    }
}