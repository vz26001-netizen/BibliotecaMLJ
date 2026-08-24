using System;
using System.Windows.Forms;
using BibliotecaML.EN;
using BibliotecaML.LN;

namespace BibliotecaML.UI
{
    public partial class frmLogin : Form
    {
        private UsuarioLN usuarioLN = new UsuarioLN();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor ingresa tu correo y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario user = usuarioLN.IniciarSesion(txtCorreo.Text.Trim(), txtContraseña.Text);

            if (user != null)
            {
                MessageBox.Show($"¡Bienvenido {user.Nombre}!", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmMenuPrincipal menu = new frmMenuPrincipal();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Clear();
                txtContraseña.Focus();
            }
        }
    }
}