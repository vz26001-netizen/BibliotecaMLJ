namespace BibliotecaML.UI
{
    partial class FormRegistroDevoluciones
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
<<<<<<< HEAD
            dtpFechaDevolucion = new DateTimePicker();
            lblFechaDevolucion = new Label();
=======
            txtFechaDevolucion = new TextBox();
            lblFechaDeDevolucion = new Label();
>>>>>>> 35b32af7975df0d18256652614923535b74542e5
            txtEstadoLibro = new TextBox();
            lblEstadoDelLibro = new Label();
            txtLibro = new TextBox();
            lblLibro = new Label();
            txtEstudiante = new TextBox();
            lblEstudiante = new Label();
            groupBox3 = new GroupBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnRegistrarDevolucion = new Button();
            btnNuevo = new Button();
<<<<<<< HEAD
            dgvDevoluciones = new DataGridView();
=======
            dataGridView1 = new DataGridView();
>>>>>>> 35b32af7975df0d18256652614923535b74542e5
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDevoluciones).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_1736212;
            groupBox1.Location = new Point(328, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(185, 167);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
<<<<<<< HEAD
            groupBox2.Controls.Add(dtpFechaDevolucion);
            groupBox2.Controls.Add(lblFechaDevolucion);
=======
            groupBox2.Controls.Add(txtFechaDevolucion);
            groupBox2.Controls.Add(lblFechaDeDevolucion);
>>>>>>> 35b32af7975df0d18256652614923535b74542e5
            groupBox2.Controls.Add(txtEstadoLibro);
            groupBox2.Controls.Add(lblEstadoDelLibro);
            groupBox2.Controls.Add(txtLibro);
            groupBox2.Controls.Add(lblLibro);
            groupBox2.Controls.Add(txtEstudiante);
            groupBox2.Controls.Add(lblEstudiante);
            groupBox2.Location = new Point(90, 256);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(760, 108);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
<<<<<<< HEAD
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Location = new Point(518, 54);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(235, 27);
            dtpFechaDevolucion.TabIndex = 7;
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaDevolucion.Location = new Point(351, 63);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(164, 18);
            lblFechaDevolucion.TabIndex = 6;
            lblFechaDevolucion.Text = "Fecha de devolución :";
=======
            // txtFechaDevolucion
            // 
            txtFechaDevolucion.BackColor = SystemColors.ScrollBar;
            txtFechaDevolucion.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFechaDevolucion.Location = new Point(453, 47);
            txtFechaDevolucion.Name = "txtFechaDevolucion";
            txtFechaDevolucion.Size = new Size(206, 21);
            txtFechaDevolucion.TabIndex = 7;
            txtFechaDevolucion.Text = "Mièrcoles,12 de agosto del 2026";
            // 
            // lblFechaDeDevolucion
            // 
            lblFechaDeDevolucion.AutoSize = true;
            lblFechaDeDevolucion.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaDeDevolucion.Location = new Point(307, 47);
            lblFechaDeDevolucion.Name = "lblFechaDeDevolucion";
            lblFechaDeDevolucion.Size = new Size(128, 15);
            lblFechaDeDevolucion.TabIndex = 6;
            lblFechaDeDevolucion.Text = "Fecha de devoluciòn :";
>>>>>>> 35b32af7975df0d18256652614923535b74542e5
            // 
            // txtEstadoLibro
            // 
            txtEstadoLibro.BackColor = SystemColors.ScrollBar;
<<<<<<< HEAD
            txtEstadoLibro.Location = new Point(516, 15);
            txtEstadoLibro.Margin = new Padding(3, 4, 3, 4);
            txtEstadoLibro.Name = "txtEstadoLibro";
            txtEstadoLibro.Size = new Size(237, 27);
            txtEstadoLibro.TabIndex = 5;
            // 
            // lblEstadoDellLibro
            // 
            lblEstadoDelLibro.AutoSize = true;
            lblEstadoDelLibro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadoDelLibro.Location = new Point(383, 19);
            lblEstadoDelLibro.Name = "lblEstadoDelLibro";
            lblEstadoDelLibro.Size = new Size(127, 18);
=======
            txtEstadoLibro.Location = new Point(453, 11);
            txtEstadoLibro.Name = "txtEstadoLibro";
            txtEstadoLibro.Size = new Size(206, 23);
            txtEstadoLibro.TabIndex = 5;
            // 
            // lblEstadoDelLibro
            // 
            lblEstadoDelLibro.AutoSize = true;
            lblEstadoDelLibro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadoDelLibro.Location = new Point(335, 14);
            lblEstadoDelLibro.Name = "lblEstadoDelLibro";
            lblEstadoDelLibro.Size = new Size(100, 15);
>>>>>>> 35b32af7975df0d18256652614923535b74542e5
            lblEstadoDelLibro.TabIndex = 4;
            lblEstadoDelLibro.Text = "Estado del libro :";
            // 
            // txtLibro
            // 
            txtLibro.BackColor = SystemColors.ScrollBar;
<<<<<<< HEAD
            txtLibro.Location = new Point(114, 59);
            txtLibro.Margin = new Padding(3, 4, 3, 4);
            txtLibro.Name = "txtLibro";
            txtLibro.Size = new Size(195, 27);
=======
            txtLibro.Location = new Point(100, 44);
            txtLibro.Name = "txtLibro";
            txtLibro.Size = new Size(171, 23);
>>>>>>> 35b32af7975df0d18256652614923535b74542e5
            txtLibro.TabIndex = 3;
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            lblLibro.Location = new Point(59, 63);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(53, 18);
=======
            lblLibro.Location = new Point(52, 47);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(42, 15);
>>>>>>> 35b32af7975df0d18256652614923535b74542e5
            lblLibro.TabIndex = 2;
            lblLibro.Text = "Libro :";
            // 
            // txtEstudiante
            // 
            txtEstudiante.BackColor = SystemColors.ScrollBar;
<<<<<<< HEAD
            txtEstudiante.Location = new Point(114, 15);
            txtEstudiante.Margin = new Padding(3, 4, 3, 4);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(195, 27);
=======
            txtEstudiante.Location = new Point(100, 11);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(171, 23);
>>>>>>> 35b32af7975df0d18256652614923535b74542e5
            txtEstudiante.TabIndex = 1;
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
<<<<<<< HEAD
            lblEstudiante.Location = new Point(24, 25);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(92, 18);
=======
            lblEstudiante.Location = new Point(21, 19);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(73, 15);
>>>>>>> 35b32af7975df0d18256652614923535b74542e5
            lblEstudiante.TabIndex = 0;
            lblEstudiante.Text = "Estudiante :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLimpiar);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(btnActualizar);
            groupBox3.Controls.Add(btnRegistrarDevolucion);
            groupBox3.Controls.Add(btnNuevo);
            groupBox3.Location = new Point(90, 372);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(760, 85);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // btnLimpiar
<<<<<<< HEAD
            // 
            btnLimpiar.BackColor = SystemColors.ScrollBar;
            btnLimpiar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(615, 24);
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
            btnLimpiar.Location = new Point(538, 18);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ScrollBar;
            btnEliminar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(395, 18);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ScrollBar;
            btnActualizar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(258, 18);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarDevolucion
            // 
            btnRegistrarDevolucion.BackColor = SystemColors.ScrollBar;
            btnRegistrarDevolucion.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarDevolucion.Location = new Point(120, 18);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Size = new Size(84, 40);
            btnRegistrarDevolucion.TabIndex = 1;
            btnRegistrarDevolucion.Text = "Registrar Devoluciòn ";
            btnRegistrarDevolucion.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ScrollBar;
            btnNuevo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(6, 18);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(69, 23);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
>>>>>>> 35b32af7975df0d18256652614923535b74542e5
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ScrollBar;
            btnEliminar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(451, 24);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ScrollBar;
            btnActualizar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(295, 24);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 31);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarDevolucion
            // 
            btnRegistrarDevolucion.BackColor = SystemColors.ScrollBar;
            btnRegistrarDevolucion.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarDevolucion.Location = new Point(137, 24);
            btnRegistrarDevolucion.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Size = new Size(115, 53);
            btnRegistrarDevolucion.TabIndex = 1;
            btnRegistrarDevolucion.Text = "Registrar Devolución ";
            btnRegistrarDevolucion.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ScrollBar;
            btnNuevo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(7, 24);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(79, 31);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // dgvDevoluciones
            // 
            dgvDevoluciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevoluciones.Location = new Point(90, 465);
            dgvDevoluciones.Margin = new Padding(3, 4, 3, 4);
            dgvDevoluciones.Name = "dgvDevoluciones";
            dgvDevoluciones.RowHeadersWidth = 51;
            dgvDevoluciones.Size = new Size(760, 89);
            dgvDevoluciones.TabIndex = 3;
            // 
            // FormRegistroDevoluciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_195947;
            ClientSize = new Size(914, 600);
            Controls.Add(dgvDevoluciones);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRegistroDevoluciones";
            Text = "REGISTRO DE DEVOLUCIONES";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDevoluciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtLibro;
        private Label lblLibro;
        private TextBox txtEstudiante;
        private Label lblEstudiante;
<<<<<<< HEAD
        private Label lblFechaDevolucion;
=======
        private TextBox txtFechaDevolucion;
        private Label lblFechaDeDevolucion;
>>>>>>> 35b32af7975df0d18256652614923535b74542e5
        private TextBox txtEstadoLibro;
        private Label lblEstadoDelLibro;
        private GroupBox groupBox3;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnRegistrarDevolucion;
        private Button btnNuevo;
        private DataGridView dgvDevoluciones;
        private DateTimePicker dtpFechaDevolucion;
    }
}