using System;
using System.Data;
using System.Data.SqlClient;
using BibliotecaML.EN;

namespace BibliotecaML.DAL
{
    public class EstudianteDAL
    {
        private Conexion conexion = new Conexion();

        public DataTable ObtenerEstudiantes()
        {
            using (var con = conexion.GetConexion())
            {
                string query = "SELECT IdEstudiante, Nombre, Apellido, Documento, Correo, Telefono FROM Estudiantes";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public bool Agregar(Estudiante pEstudiante)
        {
            using (var con = conexion.GetConexion())
            {
                string query = "INSERT INTO Estudiantes (Nombre, Apellido, Documento, Correo, Telefono) " +
                              "VALUES (@nombre, @apellido, @documento, @correo, @telefono)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombre", pEstudiante.Nombre);
                cmd.Parameters.AddWithValue("@apellido", pEstudiante.Apellido);
                cmd.Parameters.AddWithValue("@documento", pEstudiante.Documento);
                cmd.Parameters.AddWithValue("@correo", pEstudiante.Correo);
                cmd.Parameters.AddWithValue("@telefono", pEstudiante.Telefono);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Actualizar(Estudiante pEstudiante)
        {
            using (var con = conexion.GetConexion())
            {
                string query = "UPDATE Estudiantes SET Nombre=@nombre, Apellido=@apellido, Documento=@documento, " +
                              "Correo=@correo, Telefono=@telefono WHERE IdEstudiante=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", pEstudiante.IdEstudiante);
                cmd.Parameters.AddWithValue("@nombre", pEstudiante.Nombre);
                cmd.Parameters.AddWithValue("@apellido", pEstudiante.Apellido);
                cmd.Parameters.AddWithValue("@documento", pEstudiante.Documento);
                cmd.Parameters.AddWithValue("@correo", pEstudiante.Correo);
                cmd.Parameters.AddWithValue("@telefono", pEstudiante.Telefono);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Eliminar(int id)
        {
            using (var con = conexion.GetConexion())
            {
                string query = "DELETE FROM Estudiantes WHERE IdEstudiante=@id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);

                con.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
