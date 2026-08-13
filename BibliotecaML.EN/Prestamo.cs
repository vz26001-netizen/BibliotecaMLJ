using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaML.EN
{
    internal class Prestamo
    {
        public int IdPrestamo { get; set; }

        public int IdEstdiante { get; set; }

        public int IdLibro  { get; set; }

        public DateTime FechaPretamo { get; set; }

        public DateTime FechaLimite { get; set; }

        public string Estado { get; set; }
        }
}
