using System;
using System.Data;
using Microsoft.Data.SqlClient; 

namespace BibliotecaML.DAL
{
    public class DBComun 
    {
        // Ajusta el Server y Database con el nombre de tu SQL Server local
        private static string CadenaConexion = @"Server=localhost; Database=BibliotecaDB; Integrated Security=True; TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conn = new SqlConnection(CadenaConexion);
            conn.Open();
            return conn;
        }
    }
}