using System;
using System.Windows.Forms;
using BibliotecaML.EN;
using BibliotecaML.LN;

namespace BibliotecaML.UI
{
    public partial class FormRegistroDevoluciones : Form
    {
        private int idDevolucionSeleccionada = 0;

        public FormRegistroDevoluciones()
        {
            InitializeComponent();
        }

        // --- BOTÓN NUEVO ---
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            idDevolucionSeleccionada = 0;
            txtEstudiante.Focus();
        }

        // --- BOTÓN REGISTRAR DEVOLUCIÓN ---
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    Devolucion nuevaDevolucion = new Devolucion
                    {
                        Estudiante = txtEstudiante.Text.Trim(),
                        Libro = txtLibro.Text.Trim(),
                        EstadoLibro = txtEstadoLibro.Text.Trim(),
                        FechaDevolucion = dtpFechaDevolucion.Value
                    };

                    // DevolucionLN.Agregar(nuevaDevolucion);

                    MessageBox.Show("¡Devolución registrada exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la devolución: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- BOTÓN ACTUALIZAR ---
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idDevolucionSeleccionada == 0)
            {
                MessageBox.Show("Por favor, seleccione un registro de la tabla para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarCampos())
            {
                try
                {
                    Devolucion devolucionEditar = new Devolucion
                    {
                        IdDevolucion = idDevolucionSeleccionada,
                        Estudiante = txtEstudiante.Text.Trim(),
                        Libro = txtLibro.Text.Trim(),
                        EstadoLibro = txtEstadoLibro.Text.Trim(),
                        FechaDevolucion = dtpFechaDevolucion.Value
                    };

                    // DevolucionLN.Actualizar(devolucionEditar);

                    MessageBox.Show("¡Registro actualizado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- BOTÓN ELIMINAR ---
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idDevolucionSeleccionada == 0)
            {
                MessageBox.Show("Seleccione un registro de la tabla para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar esta devolución?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    // DevolucionLN.Eliminar(idDevolucionSeleccionada);

                    MessageBox.Show("Registro eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- BOTÓN LIMPIAR ---
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // --- SELECCIÓN EN EL DATAGRIDVIEW ---
        private void dgvDevoluciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvDevoluciones.Rows[e.RowIndex];

                txtEstudiante.Text = fila.Cells["Estudiante"].Value?.ToString();
                txtLibro.Text = fila.Cells["Libro"].Value?.ToString();
                txtEstadoLibro.Text = fila.Cells["EstadoLibro"].Value?.ToString();

                if (fila.Cells["FechaDevolucion"].Value != null &&
                    DateTime.TryParse(fila.Cells["FechaDevolucion"].Value.ToString(), out DateTime fechaConvertida))
                {
                    dtpFechaDevolucion.Value = fechaConvertida;
                }
            }
        }

        // --- MÉTODOS AUXILIARES ---
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtEstudiante.Text) ||
                string.IsNullOrWhiteSpace(txtLibro.Text) ||
                string.IsNullOrWhiteSpace(txtEstadoLibro.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos obligatorios.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LimpiarCampos()
        {
            txtEstudiante.Clear();
            txtLibro.Clear();
            txtEstadoLibro.Clear();
            dtpFechaDevolucion.Value = DateTime.Now;
            idDevolucionSeleccionada = 0;
            txtEstudiante.Focus();
        }
    }
}