<<<<<<< HEAD
﻿using System;
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
=======
﻿using Microsoft.Data.SqlClient;

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
>>>>>>> 35b32af7975df0d18256652614923535b74542e5
        }
    }
}