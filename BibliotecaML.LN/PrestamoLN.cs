using System.Collections.Generic;
using BibliotecaML.EN;
using BibliotecaML.DAL;

namespace BibliotecaML.LN
{
    public class PrestamoLN
    {
        public static int Agregar(Prestamo pPrestamo)
        {
            return PrestamoDAL.Agregar(pPrestamo);
        }

        public static int Modificar(Prestamo pPrestamo)
        {
            return PrestamoDAL.Modificar(pPrestamo);
        }

        public static int Eliminar(int pId)
        {
            return PrestamoDAL.Eliminar(pId);
        }

        public static List<Prestamo> ObtenerTodos()
        {
            return PrestamoDAL.ObtenerTodos();
        }
    }
}