using System;
using System.Data;
using System.Windows.Forms;

namespace BibliotecaML.UI
{
    public partial class FormREGISTRO_DE_LIBROS : Form
    {
        private DataTable tablaLibros = new DataTable();

        public FormREGISTRO_DE_LIBROS()
        {
            InitializeComponent();
            InicializarTabla();
        }

        private void InicializarTabla()
        {
            tablaLibros.Columns.Add("ID", typeof(string));
            tablaLibros.Columns.Add("Título", typeof(string));
            tablaLibros.Columns.Add("Autor", typeof(string));
            tablaLibros.Columns.Add("Editorial", typeof(string));
            tablaLibros.Columns.Add("Categoría", typeof(string));
            tablaLibros.Columns.Add("Estado", typeof(string));

            if (dgvLibros != null)
            {
                dgvLibros.DataSource = tablaLibros;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                tablaLibros.Rows.Add(
                    txtLibro.Text.Trim(),
                    txtTitulo.Text.Trim(),
                    txtAutor.Text.Trim(),
                    txtEditorial.Text.Trim(),
                    txtCategoria.Text.Trim(),
                    txtEstado.Text.Trim()
                );

                MessageBox.Show("Libro registrado exitosamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string idBuscado = txtLibro.Text.Trim();

            if (string.IsNullOrEmpty(idBuscado))
            {
                MessageBox.Show("Por favor, ingrese el ID del libro que desea actualizar.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool encontrado = false;
            foreach (DataRow fila in tablaLibros.Rows)
            {
                if (fila["ID"].ToString() == idBuscado)
                {
                    fila["Título"] = txtTitulo.Text.Trim();
                    fila["Autor"] = txtAutor.Text.Trim();
                    fila["Editorial"] = txtEditorial.Text.Trim();
                    fila["Categoría"] = txtCategoria.Text.Trim();
                    fila["Estado"] = txtEstado.Text.Trim();

                    encontrado = true;
                    MessageBox.Show("Datos del libro actualizados correctamente.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró ningún libro con ese ID.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idBuscado = txtLibro.Text.Trim();

            if (string.IsNullOrEmpty(idBuscado))
            {
                MessageBox.Show("Ingrese el ID del libro a eliminar.", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = tablaLibros.Rows.Count - 1; i >= 0; i--)
            {
                DataRow fila = tablaLibros.Rows[i];
                if (fila["ID"].ToString() == idBuscado)
                {
                    tablaLibros.Rows.Remove(fila);
                    MessageBox.Show("Libro eliminado de la lista.", "Éxito",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    return;
                }
            }

            MessageBox.Show("No se encontró el libro especificado.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtLibro.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtEditorial.Clear();
            txtCategoria.Clear();
            txtEstado.Clear();
            txtLibro.Focus();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtLibro.Text) || string.IsNullOrEmpty(txtTitulo.Text))
            {
                MessageBox.Show("El ID del Libro y el Título son campos obligatorios.",
                                "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLibros.Rows.Count)
            {
                DataGridViewRow fila = dgvLibros.Rows[e.RowIndex];
                txtLibro.Text = fila.Cells["ID"].Value?.ToString();
                txtTitulo.Text = fila.Cells["Título"].Value?.ToString();
                txtAutor.Text = fila.Cells["Autor"].Value?.ToString();
                txtEditorial.Text = fila.Cells["Editorial"].Value?.ToString();
                txtCategoria.Text = fila.Cells["Categoría"].Value?.ToString();
                txtEstado.Text = fila.Cells["Estado"].Value?.ToString();
            }
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}