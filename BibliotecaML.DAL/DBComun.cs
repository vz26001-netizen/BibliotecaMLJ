using System.Data.SqlClient;

namespace BibliotecaML.DAL
{
    public class DBComun
    {
        private static string cadena = @"Server=(localdb)\MSSQLLocalDB;Database=LibreriaML;Integrated Security=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection con = new SqlConnection(cadena);
            con.Open();
            return con;
        }
    }
}