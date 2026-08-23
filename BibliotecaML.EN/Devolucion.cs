using System;

namespace BibliotecaML.EN
{
    public class Devolucion
    {
        public int IdDevolucion { get; set; }
        public int IdPrestamo { get; set; }
        public string Estudiante { get; set; } = string.Empty;
        public string Libro { get; set; } = string.Empty;
        public string EstadoLibro { get; set; } = string.Empty;
        public DateTime FechaDevolucion { get; set; }
        public string Observaciones { get; set; } = string.Empty;
    }
}