namespace BibliotecaML.UI
{
    partial class FORMPRÉSTAMOS
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
            dtpFechaPrestamo = new DateTimePicker();
            lblFechaDePrèstamo = new Label();
            txtEstadoLibro = new TextBox();
            lblEstadoDelLibro = new Label();
            txtLibro = new TextBox();
            lblLibro = new Label();
            txtEstudiante = new TextBox();
            lblEstudiante = new Label();
            groupBox3 = new GroupBox();
            btnLimpiar = new Button();
            btEliminar = new Button();
            btnActualizar = new Button();
            btnRegistrarPréstamo = new Button();
            btnNuevo = new Button();
            dgvPréstamos = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPréstamos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_1736214;
            groupBox1.Location = new Point(323, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(187, 170);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpFechaPrestamo);
            groupBox2.Controls.Add(lblFechaDePrèstamo);
            groupBox2.Controls.Add(txtEstadoLibro);
            groupBox2.Controls.Add(lblEstadoDelLibro);
            groupBox2.Controls.Add(txtLibro);
            groupBox2.Controls.Add(lblLibro);
            groupBox2.Controls.Add(txtEstudiante);
            groupBox2.Controls.Add(lblEstudiante);
            groupBox2.Location = new Point(83, 261);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(712, 113);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Location = new Point(466, 69);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(234, 27);
            dtpFechaPrestamo.TabIndex = 4;
            // 
            // lblFechaDePrèstamo
            // 
            lblFechaDePrèstamo.AutoSize = true;
            lblFechaDePrèstamo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaDePrèstamo.Location = new Point(308, 76);
            lblFechaDePrèstamo.Name = "lblFechaDePrèstamo";
            lblFechaDePrèstamo.Size = new Size(152, 18);
            lblFechaDePrèstamo.TabIndex = 6;
            lblFechaDePrèstamo.Text = "Fecha de Préstamo :";
            lblFechaDePrèstamo.Click += lblFechaDePrèstamo_Click;
            // 
            // txtEstadoLibro
            // 
            txtEstadoLibro.BackColor = SystemColors.ScrollBar;
            txtEstadoLibro.Location = new Point(462, 25);
            txtEstadoLibro.Margin = new Padding(3, 4, 3, 4);
            txtEstadoLibro.Name = "txtEstadoLibro";
            txtEstadoLibro.Size = new Size(228, 27);
            txtEstadoLibro.TabIndex = 5;
            // 
            // lblEstadoDelLibro
            // 
            lblEstadoDelLibro.AutoSize = true;
            lblEstadoDelLibro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadoDelLibro.Location = new Point(341, 25);
            lblEstadoDelLibro.Name = "lblEstadoDelLibro";
            lblEstadoDelLibro.Size = new Size(127, 18);
            lblEstadoDelLibro.TabIndex = 4;
            lblEstadoDelLibro.Text = "Estado del libro :";
            // 
            // txtLibro
            // 
            txtLibro.BackColor = SystemColors.ScrollBar;
            txtLibro.Location = new Point(112, 71);
            txtLibro.Margin = new Padding(3, 4, 3, 4);
            txtLibro.Name = "txtLibro";
            txtLibro.Size = new Size(190, 27);
            txtLibro.TabIndex = 3;
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLibro.Location = new Point(57, 75);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(53, 18);
            lblLibro.TabIndex = 2;
            lblLibro.Text = "Libro :";
            // 
            // txtEstudiante
            // 
            txtEstudiante.BackColor = SystemColors.ScrollBar;
            txtEstudiante.Location = new Point(112, 21);
            txtEstudiante.Margin = new Padding(3, 4, 3, 4);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(190, 27);
            txtEstudiante.TabIndex = 1;
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstudiante.Location = new Point(22, 25);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(92, 18);
            lblEstudiante.TabIndex = 0;
            lblEstudiante.Text = "Estudiante :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLimpiar);
            groupBox3.Controls.Add(btEliminar);
            groupBox3.Controls.Add(btnActualizar);
            groupBox3.Controls.Add(btnRegistrarPréstamo);
            groupBox3.Controls.Add(btnNuevo);
            groupBox3.Location = new Point(83, 383);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(712, 61);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ScrollBar;
            btnLimpiar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(590, 23);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btEliminar
            // 
            btEliminar.BackColor = SystemColors.ScrollBar;
            btEliminar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEliminar.Location = new Point(462, 23);
            btEliminar.Margin = new Padding(3, 4, 3, 4);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(86, 31);
            btEliminar.TabIndex = 3;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ScrollBar;
            btnActualizar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(341, 23);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 31);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarPréstamo
            // 
            btnRegistrarPréstamo.BackColor = SystemColors.ScrollBar;
            btnRegistrarPréstamo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarPréstamo.Location = new Point(149, 23);
            btnRegistrarPréstamo.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarPréstamo.Name = "btnRegistrarPréstamo";
            btnRegistrarPréstamo.Size = new Size(154, 31);
            btnRegistrarPréstamo.TabIndex = 1;
            btnRegistrarPréstamo.Text = "Registrar Prèstamo";
            btnRegistrarPréstamo.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ScrollBar;
            btnNuevo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(7, 23);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(86, 31);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // dgvPréstamos
            // 
            dgvPréstamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPréstamos.Location = new Point(83, 452);
            dgvPréstamos.Margin = new Padding(3, 4, 3, 4);
            dgvPréstamos.Name = "dgvPréstamos";
            dgvPréstamos.RowHeadersWidth = 51;
            dgvPréstamos.Size = new Size(712, 109);
            dgvPréstamos.TabIndex = 3;
            // 
            // FORMPRÉSTAMOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_210653;
            ClientSize = new Size(914, 600);
            Controls.Add(dgvPréstamos);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FORMPRÉSTAMOS";
            Text = "REGISTRO DE PRÉSTAMOS";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPréstamos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblEstudiante;
        private Label lblFechaDePrèstamo;
        private TextBox txtEstadoLibro;
        private Label lblEstadoDelLibro;
        private TextBox txtLibro;
        private Label lblLibro;
        private TextBox txtEstudiante;
        private GroupBox groupBox3;
        private Button btnRegistrarPréstamo;
        private Button btnNuevo;
        private Button btnLimpiar;
        private Button btEliminar;
        private Button btnActualizar;
        private DataGridView dgvPréstamos;
        private DateTimePicker dtpFechaPrestamo;
    }
}