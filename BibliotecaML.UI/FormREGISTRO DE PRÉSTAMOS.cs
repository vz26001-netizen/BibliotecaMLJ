using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BibliotecaML.EN;
using BibliotecaML.LN;

namespace BibliotecaML.UI
{
    public partial class FORMPRÉSTAMOS : Form
    {
        private int idPrestamoSeleccionado = 0;

        public FORMPRÉSTAMOS()
        {
            InitializeComponent();
        }

        private void FormREGISTRO_DE_PRÈSTAMOS_Load(object sender, EventArgs e)
        {
            CargarPrestamos();
            LimpiarCampos();
        }

        // Cargar datos en el DataGridView
        private void CargarPrestamos()
        {
            try
            {
                dgvPréstamos.DataSource = PrestamoLN.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Nuevo
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Botón Registrar Préstamo
        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            try
            {
                Prestamo prestamo = new Prestamo
                {
                    Estudiante = txtEstudiante.Text.Trim(),
                    Libro = txtLibro.Text.Trim(),
                    EstadoLibro = txtEstadoLibro.Text.Trim(),
                    FechaPrestamo = dtpFechaPrestamo.Value
                };

                int resultado = PrestamoLN.Agregar(prestamo);

                if (resultado > 0)
                {
                    MessageBox.Show("Préstamo registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPrestamos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el préstamo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el préstamo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idPrestamoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro de préstamo para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            try
            {
                Prestamo prestamo = new Prestamo
                {
                    IdPrestamo = idPrestamoSeleccionado,
                    Estudiante = txtEstudiante.Text.Trim(),
                    Libro = txtLibro.Text.Trim(),
                    EstadoLibro = txtEstadoLibro.Text.Trim(),
                    FechaPrestamo = dtpFechaPrestamo.Value
                };

                int resultado = PrestamoLN.Modificar(prestamo);

                if (resultado > 0)
                {
                    MessageBox.Show("Registro de préstamo actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarPrestamos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idPrestamoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este registro de préstamo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int resultado = PrestamoLN.Eliminar(idPrestamoSeleccionado);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarPrestamos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Botón Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Resetear campos del formulario
        private void LimpiarCampos()
        {
            txtEstudiante.Clear();
            txtLibro.Clear();
            txtEstadoLibro.Clear();
            dtpFechaPrestamo.Value = DateTime.Now;
            idPrestamoSeleccionado = 0;
            txtEstudiante.Focus();
        }

        // Validación de entradas
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtEstudiante.Text) || string.IsNullOrWhiteSpace(txtLibro.Text))
            {
                MessageBox.Show("Debe completar los campos 'Estudiante' y 'Libro'.", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Cargar datos del GridView a los campos de texto
        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Se valida que e.RowIndex sea >= 0 para evitar fallos al hacer clic en los encabezados
            if (e.RowIndex >= 0 && dgvPréstamos.CurrentRow != null)
            {
                DataGridViewRow fila = dgvPréstamos.Rows[e.RowIndex];
                idPrestamoSeleccionado = Convert.ToInt32(fila.Cells["IdPrestamo"].Value);
                txtEstudiante.Text = fila.Cells["Estudiante"].Value?.ToString();
                txtLibro.Text = fila.Cells["Libro"].Value?.ToString();
                txtEstadoLibro.Text = fila.Cells["EstadoLibro"].Value?.ToString();

                if (fila.Cells["FechaPrestamo"].Value != null)
                {
                    dtpFechaPrestamo.Value = Convert.ToDateTime(fila.Cells["FechaPrestamo"].Value);
                }
            }
        }

        private void lblFechaDePrèstamo_Click(object sender, EventArgs e)
        {

        }
    }
}