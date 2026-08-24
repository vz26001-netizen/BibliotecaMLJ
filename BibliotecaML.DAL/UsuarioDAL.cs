<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using BibliotecaML.EN;

namespace BibliotecaML.DAL
{
    public class UsuarioDAL
    {
        // 1. Método para Login / Autenticación
        public static Usuario Autenticar(string pNombreUsuario, string pClave)
        {
            Usuario usuario = null;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "SELECT IdUsuario, NombreUsuario, Clave, Rol FROM Usuario " +
                               "WHERE NombreUsuario = @NombreUsuario AND Clave = @Clave";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NombreUsuario", pNombreUsuario ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Clave", pClave ?? string.Empty);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuario
                            {
                                IdUsuario = reader.GetInt32(0),
                                NombreUsuario = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                                Clave = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                                Rol = reader.IsDBNull(3) ? string.Empty : reader.GetString(3)
                            };
                        }
                    }
                }
            }
            return usuario;
        }

        // 2. Método para agregar un usuario
        public static int Agregar(Usuario pUsuario)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "INSERT INTO Usuario (NombreUsuario, Clave, Rol) VALUES (@NombreUsuario, @Clave, @Rol)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NombreUsuario", pUsuario.NombreUsuario ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Clave", pUsuario.Clave ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Rol", pUsuario.Rol ?? string.Empty);

                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 3. Método para modificar un usuario
        public static int Modificar(Usuario pUsuario)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "UPDATE Usuario SET NombreUsuario = @NombreUsuario, Clave = @Clave, Rol = @Rol " +
                               "WHERE IdUsuario = @IdUsuario";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", pUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@NombreUsuario", pUsuario.NombreUsuario ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Clave", pUsuario.Clave ?? string.Empty);
                    cmd.Parameters.AddWithValue("@Rol", pUsuario.Rol ?? string.Empty);

                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 4. Método para eliminar un usuario
        public static int Eliminar(int pIdUsuario)
        {
            int resultado = 0;
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "DELETE FROM Usuario WHERE IdUsuario = @IdUsuario";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", pIdUsuario);
                    resultado = cmd.ExecuteNonQuery();
                }
            }
            return resultado;
        }

        // 5. Método para obtener todos los usuarios
        public static List<Usuario> ObtenerTodos()
        {
            List<Usuario> lista = new List<Usuario>();
            using (SqlConnection conn = DBComun.ObtenerConexion())
            {
                string query = "SELECT IdUsuario, NombreUsuario, Clave, Rol FROM Usuario";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Usuario usuario = new Usuario
                            {
                                IdUsuario = reader.GetInt32(0),
                                NombreUsuario = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                                Clave = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                                Rol = reader.IsDBNull(3) ? string.Empty : reader.GetString(3)
                            };
                            lista.Add(usuario);
                        }
                    }
                }
            }
            return lista;
=======
﻿using System.Data.SqlClient;
using BibliotecaML.EN;
using Microsoft.Win32;

namespace BibliotecaML.DAL
{
    public partial class UsuarioDAL
    {
        public UsuarioDAL  IniciarSesion(string correo, string contrasena)
        {
            using (var con = DBComun.ObtenerConexion())
            {
                string query = "SELECT IdUsuario, Nombre, Correo, TipoUsuario FROM Usuarios WHERE Correo=@correo AND Contrasena=@contrasena";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new UsuarioDAL 
                    {
                        IdUsuario = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Correo = reader.GetString(2),
                        TipoUsuario = reader.GetString(3)
                    };
                }
                return null;
            }
>>>>>>> 35b32af7975df0d18256652614923535b74542e5
        }
    }
}