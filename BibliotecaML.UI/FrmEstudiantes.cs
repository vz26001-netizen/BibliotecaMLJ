using System;
using System.Windows.Forms;

namespace LibreriaML
{
    public partial class FormEstudiantes : Form
    {
        private EstudianteDAL estudianteDAL = new EstudianteDAL();

        public FormEstudiantes()
        {
            InitializeComponent();
        }

        private void FormEstudiantes_Load(object sender, EventArgs e)
        {
            CargarTabla();
            LimpiarCampos();
        }

        private void CargarTabla()
        {
            dgvEstudiantes.DataSource = estudianteDAL.ObtenerEstudiantes();
        }

        private void LimpiarCampos()
        {
            txtIdEstudiante.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtNombre.Focus();
        }

        // Evento Botón Nuevo / Limpiar
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Evento Botón Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Por favor complete los campos obligatorios (Nombre, Apellido, Documento).",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool exito = estudianteDAL.Agregar(
                txtNombre.Text.Trim(),
                txtApellido.Text.Trim(),
                txtDocumento.Text.Trim(),
                txtCorreo.Text.Trim(),
                txtTelefono.Text.Trim()
            );

            if (exito)
            {
                MessageBox.Show("Estudiante agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTabla();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al agregar el estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento Botón Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdEstudiante.Text))
            {
                MessageBox.Show("Seleccione un estudiante de la lista para actualizar.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(txtIdEstudiante.Text);
            bool exito = estudianteDAL.Actualizar(
                id,
                txtNombre.Text.Trim(),
                txtApellido.Text.Trim(),
                txtDocumento.Text.Trim(),
                txtCorreo.Text.Trim(),
                txtTelefono.Text.Trim()
            );

            if (exito)
            {
                MessageBox.Show("Estudiante actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTabla();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar el estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento Botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdEstudiante.Text))
            {
                MessageBox.Show("Seleccione un estudiante de la lista para eliminar.",
                                "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar este registro?",
                                                        "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtIdEstudiante.yText);
                bool exito = estudianteDAL.Eliminar(id);

                if (exito)
                {
                    MessageBox.Show("Estudiante eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTabla();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el estudiante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Evento al hacer clic en una fila del DataGridView para cargar los datos en los TextBoxes
        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEstudiantes.Rows[e.RowIndex];
                txtIdEstudiante.Text = row.Cells["IdEstudiante"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtApellido.Text = row.Cells["Apellido"].Value.ToString();
                txtDocumento.Text = row.Cells["Documento"].Value.ToString();
                txtCorreo.Text = row.Cells["Correo"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
            }
        }
    }
}
