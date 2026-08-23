using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using BibliotecaML.EN; 
namespace BibliotecaML.DAL
{
    public class EstudianteDAL
    {
        // 1. Método para agregar un estudiante
        public static int Agregar(Estudiante pEstudiante)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "INSERT INTO Estudiante (Nombre, Apellido, Carnet, Carrera, Correo, Telefono) " +
                               "VALUES (@Nombre, @Apellido, @Carnet, @Carrera, @Correo, @Telefono)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", pEstudiante.Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", pEstudiante.Apellido);
                    cmd.Parameters.AddWithValue("@Carnet", pEstudiante.Carnet);
                    cmd.Parameters.AddWithValue("@Carrera", pEstudiante.Carrera);
                    cmd.Parameters.AddWithValue("@Correo", pEstudiante.Correo);
                    cmd.Parameters.AddWithValue("@Telefono", pEstudiante.Telefono);

                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 2. Método para modificar un estudiante
        public static int Modificar(Estudiante pEstudiante)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "UPDATE Estudiante SET Nombre = @Nombre, Apellido = @Apellido, Carnet = @Carnet, " +
                               "Carrera = @Carrera, Correo = @Correo, Telefono = @Telefono " +
                               "WHERE IdEstudiante = @IdEstudiante";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdEstudiante", pEstudiante.IdEstudiante);
                    cmd.Parameters.AddWithValue("@Nombre", pEstudiante.Nombre ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Apellido", pEstudiante.Apellido ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Carnet", pEstudiante.Carnet ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Carrera", pEstudiante.Carrera ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Correo", pEstudiante.Correo ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Telefono", pEstudiante.Telefono ?? string.Empty);

                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 3. Método para eliminar un estudiante
        public static int Eliminar(int pIdEstudiante)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "DELETE FROM Estudiante WHERE IdEstudiante = @IdEstudiante";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdEstudiante", pIdEstudiante);
                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 4. Método para obtener todos los estudiantes
        public static List<Estudiante> ObtenerTodos()
        {
            List<Estudiante> lista = new List<Estudiante>();
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "SELECT IdEstudiante, Nombre, Apellido, Carnet, Carrera, Correo, Telefono FROM Estudiante";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Estudiante estudiante = new Estudiante
                            {
                                IdEstudiante = reader.GetInt32(0),
                                Nombre = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                                Apellido = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                                Carnet = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                                Carrera = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                                Correo = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                                Telefono = reader.IsDBNull(6) ? string.Empty : reader.GetString(6)
                            };

                            lista.Add(estudiante);
                        }
                    }
                }
            }
            return lista;
        }
    }
}