using System.Data;
using BibliotecaML.DAL;
using BibliotecaML.EN;

namespace BibliotecaML.LN
{
    public class EstudianteLN
    {
        private EstudianteDAL estudianteDAL = new EstudianteDAL();

        public DataTable ObtenerEstudiantes()
        {
            return estudianteDAL.ObtenerEstudiantes();
        }

        public bool Agregar(Estudiante pEstudiante)
        {
            return estudianteDAL.Agregar(pEstudiante);
        }

        public bool Actualizar(Estudiante pEstudiante)
        {
            return estudianteDAL.Actualizar(pEstudiante);
        }
        55555555555555555ty
        public bool Eliminar(int id)
        {
            return estudianteDAL.Eliminar(id);
        }
    }
}
