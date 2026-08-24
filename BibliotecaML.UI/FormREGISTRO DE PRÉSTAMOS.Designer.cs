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
<<<<<<< HEAD:BibliotecaML.UI/FormREGISTRO DE PRÉSTAMOS.Designer.cs
            dtpFechaPrestamo = new DateTimePicker();
=======
            dtpFechaPrestamo = new TextBox();
>>>>>>> 35b32af7975df0d18256652614923535b74542e5:BibliotecaML.UI/FormREGISTRO DE PRÈSTAMOS.Designer.cs
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
<<<<<<< HEAD:BibliotecaML.UI/FormREGISTRO DE PRÉSTAMOS.Designer.cs
            btnRegistrarPréstamo = new Button();
            btnNuevo = new Button();
            dgvPréstamos = new DataGridView();
=======
            btnRegistrarPrèstamo = new Button();
            btnNuevo = new Button();
            dataGridView1 = new DataGridView();
>>>>>>> 35b32af7975df0d18256652614923535b74542e5:BibliotecaML.UI/FormREGISTRO DE PRÈSTAMOS.Designer.cs
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
<<<<<<< HEAD:BibliotecaML.UI/FormREGISTRO DE PRÉSTAMOS.Designer.cs
            dtpFechaPrestamo.Location = new Point(466, 69);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(234, 27);
            dtpFechaPrestamo.TabIndex = 4;
=======
            dtpFechaPrestamo.BackColor = SystemColors.ScrollBar;
            dtpFechaPrestamo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaPrestamo.Location = new Point(404, 53);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(200, 21);
            dtpFechaPrestamo.TabIndex = 7;
            dtpFechaPrestamo.Text = "Mièrcoles, 12 de agosto del 2026";
>>>>>>> 35b32af7975df0d18256652614923535b74542e5:BibliotecaML.UI/FormREGISTRO DE PRÈSTAMOS.Designer.cs
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
<<<<<<< HEAD:BibliotecaML.UI/FormREGISTRO DE PRÉSTAMOS.Designer.cs
            txtEstadoLibro.Location = new Point(462, 25);
            txtEstadoLibro.Margin = new Padding(3, 4, 3, 4);
            txtEstadoLibro.Name = "txtEstadoLibro";
            txtEstadoLibro.Size = new Size(228, 27);
=======
            txtEstadoLibro.Location = new Point(404, 19);
            txtEstadoLibro.Name = "txtEstadoLibro";
            txtEstadoLibro.Size = new Size(200, 23);
>>>>>>> 35b32af7975df0d18256652614923535b74542e5:BibliotecaML.UI/FormREGISTRO DE PRÈSTAMOS.Designer.cs
            txtEstadoLibro.TabIndex = 5;
            // 
            // lblEstadoDelLibro
            // 
            lblEstadoDelLibro.AutoSize = true;
            lblEstadoDelLibro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
<<<<<<< HEAD:BibliotecaML.UI/FormREGISTRO DE PRÉSTAMOS.Designer.cs
            lblEstadoDelLibro.Location = new Point(341, 25);
            lblEstadoDelLibro.Name = "lblEstadoDelLibro";
            lblEstadoDelLibro.Size = new Size(127, 18);
=======
            lblEstadoDelLibro.Location = new Point(298, 19);
            lblEstadoDelLibro.Name = "lblEstadoDelLibro";
            lblEstadoDelLibro.Size = new Size(100, 15);
>>>>>>> 35b32af7975df0d18256652614923535b74542e5:BibliotecaML.UI/FormREGISTRO DE PRÈSTAMOS.Designer.cs
            lblEstadoDelLibro.TabIndex = 4;
            lblEstadoDelLibro.Text = "Estado del libro :";
            // 
            // txtLibro
            // 
            txtLibro.BackColor = SystemColors.ScrollBar;
<<<<<<< HEAD:BibliotecaML.UI/FormREGISTRO DE PRÉSTAMOS.Designer.cs
            txtLibro.Location = new Point(112, 71);
            txtLibro.Margin = new Padding(3, 4, 3, 4);
            txtLibro.Name = "txtLibro";
            txtLibro.Size = new Size(190, 27);
=======
            txtLibro.Location = new Point(98, 53);
            txtLibro.Name = "txtLibro";
            txtLibro.Size = new Size(167, 23);
>>>>>>> 35b32af7975df0d18256652614923535b74542e5:BibliotecaML.UI/FormREGISTRO DE PRÈSTAMOS.Designer.cs
            txtLibro.TabIndex = 3;
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
<<<<<<< HEAD:BibliotecaML.UI/FormREGISTRO DE PRÉSTAMOS.Designer.cs
            lblLibro.Location = new Point(57, 75);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(53, 18);
=======
            lblLibro.Location = new Point(50, 56);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(42, 15);
>>>>>>> 35b32af7975df0d18256652614923535b74542e5:BibliotecaML.UI/FormREGISTRO DE PRÈSTAMOS.Designer.cs
            lblLibro.TabIndex = 2;
            lblLibro.Text = "Libro :";
            // 
            // txtEstudiante
            // 
            txtEstudiante.BackColor = SystemColors.ScrollBar;
<<<<<<< HEAD:BibliotecaML.UI/FormREGISTRO DE PRÉSTAMOS.Designer.cs
            txtEstudiante.Location = new Point(112, 21);
            txtEstudiante.Margin = new Padding(3, 4, 3, 4);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(190, 27);
=======
            txtEstudiante.Location = new Point(98, 16);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(167, 23);
>>>>>>> 35b32af7975df0d18256652614923535b74542e5:BibliotecaML.UI/FormREGISTRO DE PRÈSTAMOS.Designer.cs
            txtEstudiante.TabIndex = 1;
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
<<<<<<< HEAD:BibliotecaML.UI/FormREGISTRO DE PRÉSTAMOS.Designer.cs
            lblEstudiante.Location = new Point(22, 25);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(92, 18);
=======
            lblEstudiante.Location = new Point(19, 19);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(73, 15);
>>>>>>> 35b32af7975df0d18256652614923535b74542e5:BibliotecaML.UI/FormREGISTRO DE PRÈSTAMOS.Designer.cs
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
<<<<<<< HEAD:BibliotecaML.UI/FormREGISTRO DE PRÉSTAMOS.Designer.cs
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
=======
            // 
            btnLimpiar.BackColor = SystemColors.ScrollBar;
            btnLimpiar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(516, 17);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btEliminar
            // 
            btEliminar.BackColor = SystemColors.ScrollBar;
            btEliminar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEliminar.Location = new Point(404, 17);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(75, 23);
            btEliminar.TabIndex = 3;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ScrollBar;
            btnActualizar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(298, 17);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarPrèstamo
            // 
            btnRegistrarPrèstamo.BackColor = SystemColors.ScrollBar;
            btnRegistrarPrèstamo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarPrèstamo.Location = new Point(130, 17);
            btnRegistrarPrèstamo.Name = "btnRegistrarPrèstamo";
            btnRegistrarPrèstamo.Size = new Size(135, 23);
            btnRegistrarPrèstamo.TabIndex = 1;
            btnRegistrarPrèstamo.Text = "Registrar Prèstamo";
            btnRegistrarPrèstamo.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ScrollBar;
            btnNuevo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(6, 17);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
>>>>>>> 35b32af7975df0d18256652614923535b74542e5:BibliotecaML.UI/FormREGISTRO DE PRÈSTAMOS.Designer.cs
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
<<<<<<< HEAD:BibliotecaML.UI/FormREGISTRO DE PRÉSTAMOS.Designer.cs
=======
        private TextBox dtpFechaPrestamo;
>>>>>>> 35b32af7975df0d18256652614923535b74542e5:BibliotecaML.UI/FormREGISTRO DE PRÈSTAMOS.Designer.cs
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