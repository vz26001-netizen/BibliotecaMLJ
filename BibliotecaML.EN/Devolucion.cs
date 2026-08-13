using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaML.EN
{
    internal class Devolucion
    {
        public int IdDevolucion { get; set; }

        public int IdPrestamo { get; set; }
        
        public DateTime FechaDevolucion { get; set; }

        public string EstadoLibro { get; set; }

        public string Observaciones { get; set; }
        }
}
