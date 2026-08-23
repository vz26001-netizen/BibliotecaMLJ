using BibliotecaML.EN;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace BibliotecaML.DAL
{
    public class ConfiguracionDAL 
    {
        // 1. Método para agregar una configuración
        public static int Agregar(Configuracion pConfiguracion)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "INSERT INTO Configuracion (Clave, Valor, Descripcion) " +
                               "VALUES (@Clave, @Valor, @Descripcion)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Clave", pConfiguracion.Clave ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Valor", pConfiguracion.Valor ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Descripcion", pConfiguracion.Descripcion ?? string.Empty);

                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 2. Método para modificar una configuración
        public static int Modificar(Configuracion pConfiguracion)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "UPDATE Configuracion SET Clave = @Clave, Valor = @Valor, " +
                               "Descripcion = @Descripcion WHERE IdConfiguracion = @IdConfiguracion";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdConfiguracion", pConfiguracion.IdConfiguracion);
                    cmd.Parameters.AddWithValue("@Clave", pConfiguracion.Clave ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Valor", pConfiguracion.Valor ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Descripcion", pConfiguracion.Descripcion ?? string.Empty);

                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 3. Método para eliminar una configuración
        public static int Eliminar(int pIdConfiguracion)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "DELETE FROM Configuracion WHERE IdConfiguracion = @IdConfiguracion";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdConfiguracion", pIdConfiguracion);
                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 4. Método para obtener todas las configuraciones
        public static List<Configuracion> ObtenerTodos()
        {
            List<Configuracion> lista = new List<Configuracion>();
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "SELECT IdConfiguracion, Clave, Valor, Descripcion FROM Configuracion";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Configuracion config = new Configuracion
                            {
                                IdConfiguracion = reader.GetInt32(0),
                                Clave = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                                Valor = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                                Descripcion = reader.IsDBNull(3) ? string.Empty : reader.GetString(3)
                            };
                            lista.Add(config);
                        }
                    }
                }
            }
            return lista;
        }
    }
}