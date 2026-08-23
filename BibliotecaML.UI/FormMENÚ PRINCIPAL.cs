using System;
using System.Windows.Forms;

namespace BibliotecaML.UI
{
    public partial class FormMENÚ_PRINCIPAL : Form
    {
        public FormMENÚ_PRINCIPAL()
        {
            InitializeComponent();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            // Fíjate en los espacios y guiones del nombre real de tu formulario:
            FormREGISTRO_DE_LIBROS formLibros = new FormREGISTRO_DE_LIBROS();
            formLibros.ShowDialog();
        }

        private void btnUsuariosEstudiantes_Click(object sender, EventArgs e)
        {
            FrmEstudiantes formEstudiantes = new FrmEstudiantes();
            formEstudiantes.ShowDialog();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            FORMPRÉSTAMOS formPrestamos = new FORMPRÉSTAMOS();
            formPrestamos.ShowDialog();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            FormRegistroDevoluciones formDevoluciones = new FormRegistroDevoluciones();
            formDevoluciones.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormGESTIÓN_DE_REPORTES formReportes = new FormGESTIÓN_DE_REPORTES();
            formReportes.ShowDialog();
        }
        private void FormMENÙ_PRINCIPAL_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }
    }
}