namespace BibliotecaML.UI
{
    partial class formREGISTRO_DE_DEVOLUCIONES
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
            lblEstudiante = new Label();
            txtEstudiante = new TextBox();
            lblLibro = new Label();
            txtLibro = new TextBox();
            lblEstadoDelLibro = new Label();
            txtEstadoDelLibro = new TextBox();
            lblFechaDeDevolucion = new Label();
            txtFechaDeDevolucion = new TextBox();
            groupBox3 = new GroupBox();
            btnNuevo = new Button();
            btnRegistrarDevolucion = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dataGridView1 = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_1736212;
            groupBox1.Location = new Point(287, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 160);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtFechaDeDevolucion);
            groupBox2.Controls.Add(lblFechaDeDevolucion);
            groupBox2.Controls.Add(txtEstadoDelLibro);
            groupBox2.Controls.Add(lblEstadoDelLibro);
            groupBox2.Controls.Add(txtLibro);
            groupBox2.Controls.Add(lblLibro);
            groupBox2.Controls.Add(txtEstudiante);
            groupBox2.Controls.Add(lblEstudiante);
            groupBox2.Location = new Point(79, 192);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(665, 81);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstudiante.Location = new Point(21, 19);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(73, 15);
            lblEstudiante.TabIndex = 0;
            lblEstudiante.Text = "Estudiante :";
            // 
            // txtEstudiante
            // 
            txtEstudiante.BackColor = SystemColors.ScrollBar;
            txtEstudiante.Location = new Point(100, 11);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(171, 23);
            txtEstudiante.TabIndex = 1;
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLibro.Location = new Point(52, 47);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(42, 15);
            lblLibro.TabIndex = 2;
            lblLibro.Text = "Libro :";
            // 
            // txtLibro
            // 
            txtLibro.BackColor = SystemColors.ScrollBar;
            txtLibro.Location = new Point(100, 44);
            txtLibro.Name = "txtLibro";
            txtLibro.Size = new Size(171, 23);
            txtLibro.TabIndex = 3;
            // 
            // lblEstadoDelLibro
            // 
            lblEstadoDelLibro.AutoSize = true;
            lblEstadoDelLibro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadoDelLibro.Location = new Point(335, 14);
            lblEstadoDelLibro.Name = "lblEstadoDelLibro";
            lblEstadoDelLibro.Size = new Size(100, 15);
            lblEstadoDelLibro.TabIndex = 4;
            lblEstadoDelLibro.Text = "Estado del libro :";
            // 
            // txtEstadoDelLibro
            // 
            txtEstadoDelLibro.BackColor = SystemColors.ScrollBar;
            txtEstadoDelLibro.Location = new Point(453, 11);
            txtEstadoDelLibro.Name = "txtEstadoDelLibro";
            txtEstadoDelLibro.Size = new Size(206, 23);
            txtEstadoDelLibro.TabIndex = 5;
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
            // 
            // txtFechaDeDevolucion
            // 
            txtFechaDeDevolucion.BackColor = SystemColors.ScrollBar;
            txtFechaDeDevolucion.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFechaDeDevolucion.Location = new Point(453, 47);
            txtFechaDeDevolucion.Name = "txtFechaDeDevolucion";
            txtFechaDeDevolucion.Size = new Size(206, 21);
            txtFechaDeDevolucion.TabIndex = 7;
            txtFechaDeDevolucion.Text = "Mièrcoles,12 de agosto del 2026";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLimpiar);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(btnActualizar);
            groupBox3.Controls.Add(btnRegistrarDevolucion);
            groupBox3.Controls.Add(btnNuevo);
            groupBox3.Location = new Point(79, 279);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(665, 64);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
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
            // btnLimpiar
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(79, 349);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(665, 67);
            dataGridView1.TabIndex = 3;
            // 
            // formREGISTRO_DE_DEVOLUCIONES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_195947;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "formREGISTRO_DE_DEVOLUCIONES";
            Text = "formREGISTRO_DE_DEVOLUCIONES";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtLibro;
        private Label lblLibro;
        private TextBox txtEstudiante;
        private Label lblEstudiante;
        private TextBox txtFechaDeDevolucion;
        private Label lblFechaDeDevolucion;
        private TextBox txtEstadoDelLibro;
        private Label lblEstadoDelLibro;
        private GroupBox groupBox3;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnRegistrarDevolucion;
        private Button btnNuevo;
        private DataGridView dataGridView1;
    }
}