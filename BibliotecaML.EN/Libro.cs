using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaML.EN
{
    internal class Libro
    {
        public int IdLibro { get; set; }

        public string Codigo { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Editorial { get; set; }

        public string Categoria { get; set; }

        public string ISBN { get; set; }

        public int AñoPublicacion { get; set; }

        public int Cantidad { get; set; }

        public int Disponibles { get; set; }

        public bool Estado { get; set; }
        }
}
