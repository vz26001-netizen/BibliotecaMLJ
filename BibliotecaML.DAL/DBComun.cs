using Microsoft.Data.SqlClient;

namespace BibliotecaML.DAL
{
    public class DBComun
    {
        private static string cadena =
            @"Server=localhost\SQLEXPRESS;Database=BibliotecaML;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection con = new SqlConnection(cadena);
            con.Open();
            return con;
        }
    }
}