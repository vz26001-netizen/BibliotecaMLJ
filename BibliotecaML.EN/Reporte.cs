using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaML.EN
{
    internal class Reporte
    {
        public int IdReporte { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFinal { get; set; }

        public string TipoReporte { get; set; }

        public DateTime FechaGeneracion { get; set; }
        }
}
