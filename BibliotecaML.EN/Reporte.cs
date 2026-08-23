using System;

namespace BibliotecaML.EN
{
    public class Reporte
    {
        public int IdReporte { get; set; }
        public string TipoReporte { get; set; } = string.Empty;
        public string Detalles { get; set; } = string.Empty;
        public DateTime FechaGeneracion { get; set; }
    }
}