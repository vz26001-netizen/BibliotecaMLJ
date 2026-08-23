using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using BibliotecaML.EN;

namespace BibliotecaML.DAL
{
    public class ReporteDAL
    {
        // 1. Método para agregar un registro de reporte
        public static int Agregar(Reporte pReporte)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "INSERT INTO Reporte (TipoReporte, FechaGeneracion, Detalles) " +
                               "VALUES (@TipoReporte, @FechaGeneracion, @Detalles)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TipoReporte", pReporte.TipoReporte ?? string.Empty);
                    cmd.Parameters.AddWithValue("@FechaGeneracion", pReporte.FechaGeneracion);
                    cmd.Parameters.AddWithValue("@Detalles", pReporte.Detalles ?? string.Empty);

                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 2. Método para eliminar un reporte
        public static int Eliminar(int pIdReporte)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "DELETE FROM Reporte WHERE IdReporte = @IdReporte";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdReporte", pIdReporte);
                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 3. Método para obtener todos los reportes
        public static List<Reporte> ObtenerTodos()
        {
            List<Reporte> lista = new List<Reporte>();
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "SELECT IdReporte, TipoReporte, FechaGeneracion, Detalles FROM Reporte";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Reporte reporte = new Reporte
                            {
                                IdReporte = reader.GetInt32(0),
                                TipoReporte = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                                FechaGeneracion = reader.GetDateTime(2),
                                Detalles = reader.IsDBNull(3) ? string.Empty : reader.GetString(3)
                            };
                            lista.Add(reporte);
                        }
                    }
                }
            }
            return lista;
        }
    }
}