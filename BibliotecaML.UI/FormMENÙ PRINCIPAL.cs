using System;
using System.Windows.Forms;

namespace BibliotecaML.UI
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnLibros_Click(object sender, EventArgs e) => new Form1().ShowDialog();
        private void btnUsuariosEstudiantes_Click(object sender, EventArgs e) => new FrmEstudiantes().ShowDialog();
        private void btnPrestamos_Click(object sender, EventArgs e) => new frmPrestamos().ShowDialog();
        private void btnDevoluciones_Click(object sender, EventArgs e) => new frmDevoluciones().ShowDialog();
        private void btnReportes_Click(object sender, EventArgs e) => new frmReportes().ShowDialog();
    }
}