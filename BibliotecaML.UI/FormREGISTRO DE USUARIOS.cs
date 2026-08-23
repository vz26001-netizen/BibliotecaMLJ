using System;
using System.Windows.Forms;
using BibliotecaML.EN;
using BibliotecaML.LN;

namespace BibliotecaML.UI
{
    public partial class FormREGISTRO_DE_USUARIOS : Form
    {
        public FormREGISTRO_DE_USUARIOS()
        {
            InitializeComponent();

            // Ocultar caracteres en campos de contraseña
            if (txtContraseña != null) txtContraseña.PasswordChar = '*';
            if (txtConfirmarContraseña != null) txtConfirmarContraseña.PasswordChar = '*';
        }

        // Evento único para el botón registrar
        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            // Campos obligatorios
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmarContraseña.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar tipo de usuario
            if (string.IsNullOrWhiteSpace(cmbTipoUsuario.Text))
            {
                MessageBox.Show("Por favor, seleccione un tipo de usuario.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipoUsuario.Focus();
                return;
            }

            // Validar contraseñas
            if (txtContraseña.Text.Trim() != txtConfirmarContraseña.Text.Trim())
            {
                MessageBox.Show("Las contraseñas ingresadas no coinciden. Verifíquelas e intente nuevamente.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmarContraseña.Clear();
                txtConfirmarContraseña.Focus();
                return;
            }

            try
            {
                Usuario nuevoUsuario = new Usuario
                {
                    NombreUsuario = txtNombre.Text.Trim(),
                    Correo = txtCorreo.Text.Trim(),
                    TipoUsuario = cmbTipoUsuario.Text.Trim(),
                    Clave = txtContraseña.Text.Trim()
                };

                MessageBox.Show("¡Usuario registrado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
            txtConfirmarContraseña.Clear();

            if (cmbTipoUsuario.Items.Count > 0)
            {
                cmbTipoUsuario.SelectedIndex = 0;
            }
            else
            {
                cmbTipoUsuario.Text = string.Empty;
            }

            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea limpiar todos los campos?",
                "Limpiar Formulario",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                LimpiarFormulario();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }
    }
}