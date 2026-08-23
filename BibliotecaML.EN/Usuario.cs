using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaML.EN
{
    public class Usuario
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;

        // Propiedad requerida por FormREGISTRO DE USUARIOS
        public string NombreUsuario { get; set; } = string.Empty;

        // Mantienes UsuarioLogin por si lo usas en otra parte
        public string UsuarioLogin { get; set; } = string.Empty;

        // Propiedades de autenticación y correo
        public string Correo { get; set; } = string.Empty;

        public string Clave { get; set; } = string.Empty;

        public string Contraseña { get; set; } = string.Empty;

        // Rol y tipo de usuario
        public string TipoUsuario { get; set; } = string.Empty;

        public string Rol { get; set; } = string.Empty;

        public bool Estado { get; set; }
    }
}