using System;
using System.Windows.Forms;

namespace BibliotecaML.UI
{
    public partial class FormREGISTRO_DE_USUARIOS : Form
    {
        private UsuarioDAL usuarioDAL = new UsuarioDAL();

        public FormREGISTRO_DE_USUARIOS()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(cmbTipoUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmarContrasena.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.",
                                "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que las contraseñas coincidan
            if (txtContrasena.Text != txtConfirmarContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Inténtelo de nuevo.",
                                "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmarContrasena.Clear();
                txtContrasena.Focus();
                return;
            }

            // 3. Verificar si el correo ya está registrado
            if (usuarioDAL.ExisteCorreo(txtCorreo.Text.Trim()))
            {
                MessageBox.Show("El correo ingresado ya se encuentra registrado.",
                                "Usuario existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCorreo.Focus();
                return;
            }

            // 4. Registrar en la base de datos
            bool exito = usuarioDAL.RegistrarUsuario(
                txtNombre.Text.Trim(),
                txtCorreo.Text.Trim(),
                cmbTipoUsuario.Text.Trim(),
                txtContrasena.Text
            );

            if (exito)
            {
                MessageBox.Show("Usuario registrado con éxito.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            cmbTipoUsuario.SelectedIndex = -1;
            txtContrasena.Clear();
            txtConfirmarContrasena.Clear();
            txtNombre.Focus();
        }
    }
}

