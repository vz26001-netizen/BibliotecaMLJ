using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using BibliotecaML.EN;

namespace BibliotecaML.DAL
{
    public class PrestamoDAL
    {
        // 1. Método para agregar un préstamo
        public static int Agregar(Prestamo pPrestamo)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "INSERT INTO Prestamo (IdEstudiante, IdLibro, FechaPrestamo, FechaDevolucionEsperada, Estado) " +
                               "VALUES (@IdEstudiante, @IdLibro, @FechaPrestamo, @FechaDevolucionEsperada, @Estado)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdEstudiante", pPrestamo.IdEstudiante);
                    cmd.Parameters.AddWithValue("@IdLibro", pPrestamo.IdLibro);
                    cmd.Parameters.AddWithValue("@FechaPrestamo", pPrestamo.FechaPrestamo);
                    cmd.Parameters.AddWithValue("@FechaDevolucionEsperada", pPrestamo.FechaDevolucionEsperada);
                    cmd.Parameters.AddWithValue("@Estado", pPrestamo.Estado ?? string.Empty);

                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 2. Método para modificar un préstamo
        public static int Modificar(Prestamo pPrestamo)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "UPDATE Prestamo SET IdEstudiante = @IdEstudiante, IdLibro = @IdLibro, " +
                               "FechaPrestamo = @FechaPrestamo, FechaDevolucionEsperada = @FechaDevolucionEsperada, " +
                               "Estado = @Estado WHERE IdPrestamo = @IdPrestamo";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdPrestamo", pPrestamo.IdPrestamo);
                    cmd.Parameters.AddWithValue("@IdEstudiante", pPrestamo.IdEstudiante);
                    cmd.Parameters.AddWithValue("@IdLibro", pPrestamo.IdLibro);
                    cmd.Parameters.AddWithValue("@FechaPrestamo", pPrestamo.FechaPrestamo);
                    cmd.Parameters.AddWithValue("@FechaDevolucionEsperada", pPrestamo.FechaDevolucionEsperada);
                    cmd.Parameters.AddWithValue("@Estado", pPrestamo.Estado ?? string.Empty);

                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 3. Método para eliminar un préstamo
        public static int Eliminar(int pIdPrestamo)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "DELETE FROM Prestamo WHERE IdPrestamo = @IdPrestamo";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdPrestamo", pIdPrestamo);
                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 4. Método para obtener todos los préstamos
        public static List<Prestamo> ObtenerTodos()
        {
            List<Prestamo> lista = new List<Prestamo>();
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "SELECT IdPrestamo, IdEstudiante, IdLibro, FechaPrestamo, FechaDevolucionEsperada, Estado FROM Prestamo";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Prestamo prestamo = new Prestamo
                            {
                                IdPrestamo = reader.GetInt32(0),
                                IdEstudiante = reader.GetInt32(1),
                                IdLibro = reader.GetInt32(2),
                                FechaPrestamo = reader.GetDateTime(3),
                                FechaDevolucionEsperada = reader.GetDateTime(4),
                                Estado = reader.IsDBNull(5) ? string.Empty : reader.GetString(5)
                            };
                            lista.Add(prestamo);
                        }
                    }
                }
            }
            return lista;
        }
    }
}