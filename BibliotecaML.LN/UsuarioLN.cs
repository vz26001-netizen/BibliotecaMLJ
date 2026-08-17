using BibliotecaML.DAL;
using BibliotecaML.EN;

namespace BibliotecaML.LN
{
    public partial class UsuarioLN
    {
        private UsuarioDAL usuarioDAL = new UsuarioDAL();

        public Usuario IniciarSesion(string correo, string contrasena)
        {
            return usuarioDAL.IniciarSesion(correo, contrasena);
        }
    }
}