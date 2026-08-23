using System.Collections.Generic;
using BibliotecaML.DAL;
using BibliotecaML.EN;

namespace BibliotecaML.LN
{
    public class DevolucionLN
    {
        public int Registrar(Devolucion pDevolucion)
        {
            return DevolucionDAL.Agregar(pDevolucion);
        }

        public int Modificar(Devolucion pDevolucion)
        {
            return DevolucionDAL.Modificar(pDevolucion);
        }

        public int Eliminar(Devolucion pDevolucion)
        {
            return DevolucionDAL.Eliminar(pDevolucion.IdDevolucion);
        }

        public List<Devolucion> ObtenerTodos()
        {
            return DevolucionDAL.ObtenerTodos();
        }
    }
}