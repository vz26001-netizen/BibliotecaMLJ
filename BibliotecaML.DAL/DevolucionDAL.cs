using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using BibliotecaML.EN;

namespace BibliotecaML.DAL
{
    public class DevolucionDAL
    {
        // 1. Método para agregar una devolución
        public static int Agregar(Devolucion pDevolucion)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "INSERT INTO Devolucion (IdPrestamo, FechaDevolucion, EstadoLibro, Observaciones) " +
                               "VALUES (@IdPrestamo, @FechaDevolucion, @EstadoLibro, @Observaciones)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdPrestamo", pDevolucion.IdPrestamo); // Corregido el typo (IdPrestSamo -> IdPrestamo)
                    cmd.Parameters.AddWithValue("@FechaDevolucion", pDevolucion.FechaDevolucion);
                    cmd.Parameters.AddWithValue("@EstadoLibro", pDevolucion.EstadoLibro ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Observaciones", pDevolucion.Observaciones ?? string.Empty);

                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 2. Método para modificar una devolución existente
        public static int Modificar(Devolucion pDevolucion)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "UPDATE Devolucion SET IdPrestamo = @IdPrestamo, FechaDevolucion = @FechaDevolucion, " +
                               "EstadoLibro = @EstadoLibro, Observaciones = @Observaciones " +
                               "WHERE IdDevolucion = @IdDevolucion";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdDevolucion", pDevolucion.IdDevolucion);
                    cmd.Parameters.AddWithValue("@IdPrestamo", pDevolucion.IdPrestamo);
                    cmd.Parameters.AddWithValue("@FechaDevolucion", pDevolucion.FechaDevolucion);
                    cmd.Parameters.AddWithValue("@EstadoLibro", pDevolucion.EstadoLibro ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Observaciones", pDevolucion.Observaciones ?? string.Empty);

                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 3. Método para eliminar un registro
        public static int Eliminar(int pIdDevolucion)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "DELETE FROM Devolucion WHERE IdDevolucion = @IdDevolucion";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdDevolucion", pIdDevolucion);
                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 4. Método para obtener todos los registros
        public static List<Devolucion> ObtenerTodos()
        {
            List<Devolucion> lista = new List<Devolucion>();
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "SELECT IdDevolucion, IdPrestamo, FechaDevolucion, EstadoLibro, Observaciones FROM Devolucion";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Devolucion devolucion = new Devolucion
                            {
                                IdDevolucion = reader.GetInt32(0),
                                IdPrestamo = reader.GetInt32(1),
                                FechaDevolucion = reader.GetDateTime(2),
                                EstadoLibro = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                                Observaciones = reader.IsDBNull(4) ? string.Empty : reader.GetString(4)
                            };
                            lista.Add(devolucion);
                        }
                    }
                }
            }
            return lista;
        }
    }
}