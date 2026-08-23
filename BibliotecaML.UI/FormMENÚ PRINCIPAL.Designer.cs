namespace BibliotecaML.UI
{
    partial class FormMENÚ_PRINCIPAL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblMenu = new Label();
            label1 = new Label();
            grpContenedorBotones = new GroupBox();
            btnReportes = new Button();
            btnDevoluciones = new Button();
            btnPréstamos = new Button();
            btnUsuariosEstudiantes = new Button();
            btnLibros = new Button();
            groupBox2.SuspendLayout();
            grpContenedorBotones.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_1736215;
            groupBox1.Location = new Point(319, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(186, 167);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblMenu);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(193, 284);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(489, 39);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.Location = new Point(176, 3);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(91, 32);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "MENÚ";
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // grpContenedorBotones
            // 
            grpContenedorBotones.Controls.Add(btnReportes);
            grpContenedorBotones.Controls.Add(btnDevoluciones);
            grpContenedorBotones.Controls.Add(btnPréstamos);
            grpContenedorBotones.Controls.Add(btnUsuariosEstudiantes);
            grpContenedorBotones.Controls.Add(btnLibros);
            grpContenedorBotones.Location = new Point(193, 353);
            grpContenedorBotones.Margin = new Padding(3, 4, 3, 4);
            grpContenedorBotones.Name = "grpContenedorBotones";
            grpContenedorBotones.Padding = new Padding(3, 4, 3, 4);
            grpContenedorBotones.Size = new Size(489, 139);
            grpContenedorBotones.TabIndex = 2;
            grpContenedorBotones.TabStop = false;
            grpContenedorBotones.Text = "Opciones";
            // 
            // btnReportes
            // 
            btnReportes.BackColor = SystemColors.ScrollBar;
            btnReportes.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.Location = new Point(291, 91);
            btnReportes.Margin = new Padding(3, 4, 3, 4);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(86, 31);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnDevoluciones
            // 
            btnDevoluciones.BackColor = SystemColors.ScrollBar;
            btnDevoluciones.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDevoluciones.Location = new Point(79, 91);
            btnDevoluciones.Margin = new Padding(3, 4, 3, 4);
            btnDevoluciones.Name = "btnDevoluciones";
            btnDevoluciones.Size = new Size(129, 31);
            btnDevoluciones.TabIndex = 3;
            btnDevoluciones.Text = "Devoluciones";
            btnDevoluciones.UseVisualStyleBackColor = false;
            btnDevoluciones.Click += btnDevoluciones_Click;
            // 
            // btnPréstamos
            // 
            btnPréstamos.BackColor = SystemColors.ScrollBar;
            btnPréstamos.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPréstamos.Location = new Point(360, 29);
            btnPréstamos.Margin = new Padding(3, 4, 3, 4);
            btnPréstamos.Name = "btnPréstamos";
            btnPréstamos.Size = new Size(86, 31);
            btnPréstamos.TabIndex = 2;
            btnPréstamos.Text = "Préstamos";
            btnPréstamos.UseVisualStyleBackColor = false;
            btnPréstamos.Click += btnPrestamos_Click;
            // 
            // btnUsuariosEstudiantes
            // 
            btnUsuariosEstudiantes.BackColor = SystemColors.ScrollBar;
            btnUsuariosEstudiantes.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuariosEstudiantes.Location = new Point(142, 29);
            btnUsuariosEstudiantes.Margin = new Padding(3, 4, 3, 4);
            btnUsuariosEstudiantes.Name = "btnUsuariosEstudiantes";
            btnUsuariosEstudiantes.Size = new Size(189, 31);
            btnUsuariosEstudiantes.TabIndex = 1;
            btnUsuariosEstudiantes.Text = "Usuarios / Estudiantes";
            btnUsuariosEstudiantes.UseVisualStyleBackColor = false;
            btnUsuariosEstudiantes.Click += btnUsuariosEstudiantes_Click;
            // 
            // btnLibros
            // 
            btnLibros.BackColor = SystemColors.ScrollBar;
            btnLibros.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLibros.Location = new Point(22, 29);
            btnLibros.Margin = new Padding(3, 4, 3, 4);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(86, 31);
            btnLibros.TabIndex = 0;
            btnLibros.Text = "Libros ";
            btnLibros.UseVisualStyleBackColor = false;
            btnLibros.Click += btnLibros_Click;
            // 
            // FormMENÚ_PRINCIPAL
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_212945;
            ClientSize = new Size(914, 600);
            Controls.Add(grpContenedorBotones);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMENÚ_PRINCIPAL";
            Text = "MENÚ PRINCIPAL";
            FormClosing += FormMENÙ_PRINCIPAL_FormClosing;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpContenedorBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox grpContenedorBotones;
        private Button btnUsuariosEstudiantes;
        private Button btnLibros;
        private Button btnDevoluciones;
        private Button btnPréstamos;
        private Button btnReportes;
        private Label lblMenu;
    }
}