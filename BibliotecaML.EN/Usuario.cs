using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaML.EN
{
    internal class Usuario
    {
        public int IdUsuario { get; set; }

       public string Nombre { get; set; }
       
       public string Apellido { get; set; }

       public string UsuarioLogin { get; set; }

       public string Contraseña { get; set; }

       public string Rol { get; set; }

       public bool Estado { get; set; }
        }
}
