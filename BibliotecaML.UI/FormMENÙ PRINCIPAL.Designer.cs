using System;
using System.Windows.Forms;
using BibliotecaML.EN;

namespace BibliotecaML.UI
{
    public partial class FormMENU_PRINCIPAL : Form
    {
        private Usuario usuarioSesion;

        public FormMENU_PRINCIPAL(Usuario usuario)
        {
            InitializeComponent();
            usuarioSesion = usuario;
        }

        private void FormMENU_PRINCIPAL_Load(object sender, EventArgs e)
        {
            // Muestra quién inició sesión en el formulario (si tienes una etiqueta lblUsuario)
            // lblUsuario.Text = "Usuario: " + usuarioSesion.Nombre;
        }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            FormEstudiantes frm = new FormEstudiantes();
            frm.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormREGISTRO_DE_USUARIOS frm = new FormREGISTRO_DE_USUARIOS();
            frm.ShowDialog();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            formREGISTRO_DE_LIBROS frm = new formREGISTRO_DE_LIBROS();
            frm.ShowDialog();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            FormREGISTRO_DE_PRÈSTAMOS frm = new FormREGISTRO_DE_PRÈSTAMOS();
            frm.ShowDialog();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            formREGISTRO_DE_DEVOLUCIONES frm = new formREGISTRO_DE_DEVOLUCIONES();
            frm.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormGESTIÒN_DE_REPORTES frm = new FormGESTIÒN_DE_REPORTES();
            frm.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }
    }
}