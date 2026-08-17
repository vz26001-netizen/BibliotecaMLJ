using System;
using System.Windows.Forms;
using BibliotecaML.EN;
using BibliotecaML.LN;

namespace BibliotecaML.UI
{
    public partial class FrmEstudiantes : Form
    {
        private EstudianteLN estudianteLN = new EstudianteLN();
        private int idEstudianteSeleccionado = 0;

        public FrmEstudiantes()
        {
            InitializeComponent();
        }

        private void FrmEstudiantes_Load(object sender, EventArgs e) => CargarTabla();

        private void CargarTabla() => dgvEstudiantes.DataSource = estudianteLN.ObtenerEstudiantes();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Nombre y Apellido son campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Estudiante estudiante = new Estudiante
            {
                IdEstudiante = idEstudianteSeleccionado,
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Documento = txtDocumento.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Telefono = txtTelefono.Text.Trim()
            };

            bool ok = idEstudianteSeleccionado == 0 ? estudianteLN.Agregar(estudiante) : estudianteLN.Actualizar(estudiante);

            if (ok)
            {
                MessageBox.Show("Estudiante guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
                CargarTabla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idEstudianteSeleccionado > 0)
            {
                if (MessageBox.Show("¿Desea eliminar este estudiante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (estudianteLN.Eliminar(idEstudianteSeleccionado))
                    {
                        MessageBox.Show("Estudiante eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarTabla();
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarCampos();

        private void LimpiarCampos()
        {
            idEstudianteSeleccionado = 0;
            txtIdEstudiante.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDocumento.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
        }
    }
}