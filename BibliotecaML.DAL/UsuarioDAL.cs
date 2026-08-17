using System.Data.SqlClient;
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
        }
    }
}
