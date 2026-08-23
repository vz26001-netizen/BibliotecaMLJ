namespace BibliotecaML.EN
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string Editorial { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string ISBNCodigo { get; set; } = string.Empty;
        public int AnioPublicacion { get; set; }
        public int CantidadDisponible { get; set; }
        public bool Estado { get; set; }
    }
}