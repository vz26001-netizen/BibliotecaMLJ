using System;
using System.Windows.Forms;

namespace BibliotecaML.UI
{
    public partial class FormINICIO_DE_SESION : Form
    {
        public FormINICIO_DE_SESION()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            FormMENÚ_PRINCIPAL menu = new FormMENÚ_PRINCIPAL();
            menu.Show();
            this.Hide();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // FormINICIO_DE_SESION
            // 
            ClientSize = new Size(655, 393);
            Name = "FormINICIO_DE_SESION";
            Text = "INICIO DE SESIÓN";
            ResumeLayout(false);

        }
    }
}