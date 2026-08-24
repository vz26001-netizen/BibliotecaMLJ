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

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblHolaBienvenido = new Label();
            groupBox3 = new GroupBox();
            btnLibros = new Button();
            btnUsuariosEstudiantes = new Button();
            btnPrestamos = new Button();
            btnDevoluciones = new Button();
            btnReportes = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_1736219;
            groupBox1.Location = new Point(348, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 171);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblHolaBienvenido);
            groupBox2.Location = new Point(194, 189);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(504, 51);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // lblHolaBienvenido
            // 
            lblHolaBienvenido.AutoSize = true;
            lblHolaBienvenido.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHolaBienvenido.Location = new Point(91, 19);
            lblHolaBienvenido.Name = "lblHolaBienvenido";
            lblHolaBienvenido.Size = new Size(328, 22);
            lblHolaBienvenido.TabIndex = 0;
            lblHolaBienvenido.Text = "HOLA BIENVENIDO/A LIBRERIA ML";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnReportes);
            groupBox3.Controls.Add(btnDevoluciones);
            groupBox3.Controls.Add(btnPrestamos);
            groupBox3.Controls.Add(btnUsuariosEstudiantes);
            groupBox3.Controls.Add(btnLibros);
            groupBox3.Location = new Point(194, 273);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(504, 100);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // btnLibros
            // 
            btnLibros.BackColor = SystemColors.ScrollBar;
            btnLibros.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLibros.Location = new Point(37, 22);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(75, 23);
            btnLibros.TabIndex = 0;
            btnLibros.Text = "Libros";
            btnLibros.UseVisualStyleBackColor = false;
            // 
            // btnUsuariosEstudiantes
            // 
            btnUsuariosEstudiantes.BackColor = SystemColors.ScrollBar;
            btnUsuariosEstudiantes.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuariosEstudiantes.Location = new Point(169, 22);
            btnUsuariosEstudiantes.Name = "btnUsuariosEstudiantes";
            btnUsuariosEstudiantes.Size = new Size(147, 23);
            btnUsuariosEstudiantes.TabIndex = 1;
            btnUsuariosEstudiantes.Text = "Usuarios/Estudiantes";
            btnUsuariosEstudiantes.UseVisualStyleBackColor = false;
            // 
            // btnPrestamos
            // 
            btnPrestamos.BackColor = SystemColors.ScrollBar;
            btnPrestamos.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrestamos.Location = new Point(367, 22);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(104, 23);
            btnPrestamos.TabIndex = 2;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.UseVisualStyleBackColor = false;
            // 
            // btnDevoluciones
            // 
            btnDevoluciones.BackColor = SystemColors.ScrollBar;
            btnDevoluciones.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDevoluciones.Location = new Point(91, 61);
            btnDevoluciones.Name = "btnDevoluciones";
            btnDevoluciones.Size = new Size(105, 23);
            btnDevoluciones.TabIndex = 3;
            btnDevoluciones.Text = "Devoluciones";
            btnDevoluciones.UseVisualStyleBackColor = false;
            btnDevoluciones.Click += button1_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = SystemColors.ScrollBar;
            btnReportes.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.Location = new Point(306, 61);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(102, 23);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            // 
            // frmMenuPrincipal
            // 
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_1959471;
            ClientSize = new Size(887, 441);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmMenuPrincipal";
            Text = "MENÙ PRINCIPAL";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);

        }

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblHolaBienvenido;
        private GroupBox groupBox3;
        private Button btnDevoluciones;
        private Button btnPrestamos;
        private Button btnUsuariosEstudiantes;
        private Button btnLibros;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private Button btnReportes;
    }
}