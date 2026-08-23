using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BibliotecaML.EN;
using BibliotecaML.LN;

namespace BibliotecaML.UI
{
    public partial class FrmEstudiantes : Form
    {
        private int idEstudianteSeleccionado = 0;

        public FrmEstudiantes()
        {
            InitializeComponent();
        }

        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {
            CargarEstudiantes();
            LimpiarCampos();
        }

        // Cargar datos en la grilla
        private void CargarEstudiantes()
        {
            try
            {
                // dataGridView1.DataSource = EstudianteLN.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de estudiantes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Botón Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                Estudiante estudiante = new Estudiante
                {
                    Nombre = txtIdNombre.Text.Trim(),
                    Apellido = txtIdApellido.Text.Trim(),
                    Documento = txtIdDocumento.Text.Trim(),
                    Correo = txIdCorreo.Text.Trim(),
                    Telefono = txtIdTelefono.Text.Trim()
                };

                // int resultado = EstudianteLN.Agregar(estudiante);
                MessageBox.Show("Estudiante registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEstudiantes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el estudiante: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idEstudianteSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un estudiante de la tabla para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                Estudiante estudiante = new Estudiante
                {
                    IdEstudiante = idEstudianteSeleccionado,
                    Nombre = txtIdNombre.Text.Trim(),
                    Apellido = txtIdApellido.Text.Trim(),
                    Documento = txtIdDocumento.Text.Trim(),
                    Correo = txIdCorreo.Text.Trim(),
                    Telefono = txtIdTelefono.Text.Trim()
                };

                // int resultado = EstudianteLN.Modificar(estudiante);
                MessageBox.Show("Datos del estudiante actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEstudiantes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idEstudianteSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un estudiante para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este estudiante?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // int resultado = EstudianteLN.Eliminar(idEstudianteSeleccionado);
                    MessageBox.Show("Estudiante eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEstudiantes();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Botón Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Método auxiliar para resetear entradas
        private void LimpiarCampos()
        {
            txtEstudiante.Clear();
            txtIdNombre.Clear();
            txtIdApellido.Clear();
            txtIdDocumento.Clear();
            txIdCorreo.Clear();
            txtIdTelefono.Clear();
            idEstudianteSeleccionado = 0;
            txtIdNombre.Focus();
        }

        // Validación de datos
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtIdNombre.Text) || string.IsNullOrWhiteSpace(txtIdApellido.Text))
            {
                MessageBox.Show("Los campos Nombre y Apellido son obligatorios.", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void grDatos_Enter(object sender, EventArgs e)
        {

        }

        // Evento al hacer clic en una fila del DataGridView (Única versión)
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvEstudiantes.Rows[e.RowIndex];

                if (fila.Cells["ColIdEstudiante"].Value != null)
                {
                    idEstudianteSeleccionado = Convert.ToInt32(fila.Cells["ColIdEstudiante"].Value);
                    txtEstudiante.Text = idEstudianteSeleccionado.ToString();
                }

                txtIdNombre.Text = fila.Cells["colNombre"].Value?.ToString();
                txtIdApellido.Text = fila.Cells["colApellido"].Value?.ToString();
                txtIdDocumento.Text = fila.Cells["colDocumento"].Value?.ToString();
                txIdCorreo.Text = fila.Cells["colCorreo"].Value?.ToString();
                txtIdTelefono.Text = fila.Cells["colTelefono"].Value?.ToString();
            }
        }

        private void lblGestiòndeEstudiantes_Enter(object sender, EventArgs e)
        {

        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}