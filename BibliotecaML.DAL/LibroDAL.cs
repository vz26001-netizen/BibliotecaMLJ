using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using BibliotecaML.EN;

namespace BibliotecaML.DAL
{
    public class LibroDAL
    {
        // 1. Método para agregar un libro
        public static int Agregar(Libro pLibro)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "INSERT INTO Libro (Titulo, Autor, ISBNCodigo, Editorial, AnioPublicacion, CantidadDisponible) " +
                               "VALUES (@Titulo, @Autor, @ISBNCodigo, @Editorial, @AnioPublicacion, @CantidadDisponible)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Titulo", pLibro.Titulo ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Autor", pLibro.Autor ?? string.Empty);
                    cmd.Parameters.AddWithValue("@ISBNCodigo", pLibro.ISBNCodigo ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Editorial", pLibro.Editorial ?? string.Empty);
                    cmd.Parameters.AddWithValue("@AnioPublicacion", pLibro.AnioPublicacion);
                    cmd.Parameters.AddWithValue("@CantidadDisponible", pLibro.CantidadDisponible);

                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 2. Método para modificar un libro
        public static int Modificar(Libro pLibro)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "UPDATE Libro SET Titulo = @Titulo, Autor = @Autor, ISBNCodigo = @ISBNCodigo, " +
                               "Editorial = @Editorial, AnioPublicacion = @AnioPublicacion, CantidadDisponible = @CantidadDisponible " +
                               "WHERE IdLibro = @IdLibro";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdLibro", pLibro.IdLibro);
                    cmd.Parameters.AddWithValue("@Titulo", pLibro.Titulo ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Autor", pLibro.Autor ?? string.Empty);
                    cmd.Parameters.AddWithValue("@ISBNCodigo", pLibro.ISBNCodigo ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Editorial", pLibro.Editorial ?? string.Empty);
                    cmd.Parameters.AddWithValue("@AnioPublicacion", pLibro.AnioPublicacion);
                    cmd.Parameters.AddWithValue("@CantidadDisponible", pLibro.CantidadDisponible);

                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 3. Método para eliminar un libro
        public static int Eliminar(int pIdLibro)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "DELETE FROM Libro WHERE IdLibro = @IdLibro";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdLibro", pIdLibro);
                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 4. Método para obtener todos los libros
        public static List<Libro> ObtenerTodos()
        {
            List<Libro> lista = new List<Libro>();
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "SELECT IdLibro, Titulo, Autor, ISBNCodigo, Editorial, AnioPublicacion, CantidadDisponible FROM Libro";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Libro libro = new Libro
                            {
                                IdLibro = reader.GetInt32(0),
                                Titulo = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                                Autor = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                                ISBNCodigo = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                                Editorial = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                                AnioPublicacion = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                                CantidadDisponible = reader.IsDBNull(6) ? 0 : reader.GetInt32(6)
                            };
                            lista.Add(libro);
                        }
                    }
                }
            }
            return lista;
        }
    }
}