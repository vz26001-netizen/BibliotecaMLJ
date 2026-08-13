namespace BibliotecaML.UI
{
    partial class FormREGISTRO_DE_PRÈSTAMOS
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
            textBox1 = new TextBox();
            lblLibro = new Label();
            textBox2 = new TextBox();
            lblEstadoDelLibro = new Label();
            textBox3 = new TextBox();
            lblFechaDePrèstamo = new Label();
            textBox4 = new TextBox();
            groupBox3 = new GroupBox();
            btnNuevo = new Button();
            btnRegistrarPrèstamo = new Button();
            btnActualizar = new Button();
            btEliminar = new Button();
            btnLimpiar = new Button();
            dataGridView1 = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_1736214;
            groupBox1.Location = new Point(283, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 169);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(lblFechaDePrèstamo);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(lblEstadoDelLibro);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(lblLibro);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(lblEstudiante);
            groupBox2.Location = new Point(73, 196);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(623, 85);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstudiante.Location = new Point(19, 19);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(73, 15);
            lblEstudiante.TabIndex = 0;
            lblEstudiante.Text = "Estudiante :";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(98, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 23);
            textBox1.TabIndex = 1;
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLibro.Location = new Point(50, 56);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(42, 15);
            lblLibro.TabIndex = 2;
            lblLibro.Text = "Libro :";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(98, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 23);
            textBox2.TabIndex = 3;
            // 
            // lblEstadoDelLibro
            // 
            lblEstadoDelLibro.AutoSize = true;
            lblEstadoDelLibro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstadoDelLibro.Location = new Point(298, 19);
            lblEstadoDelLibro.Name = "lblEstadoDelLibro";
            lblEstadoDelLibro.Size = new Size(100, 15);
            lblEstadoDelLibro.TabIndex = 4;
            lblEstadoDelLibro.Text = "Estado del libro :";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ScrollBar;
            textBox3.Location = new Point(404, 19);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 5;
            // 
            // lblFechaDePrèstamo
            // 
            lblFechaDePrèstamo.AutoSize = true;
            lblFechaDePrèstamo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaDePrèstamo.Location = new Point(279, 53);
            lblFechaDePrèstamo.Name = "lblFechaDePrèstamo";
            lblFechaDePrèstamo.Size = new Size(119, 15);
            lblFechaDePrèstamo.TabIndex = 6;
            lblFechaDePrèstamo.Text = "Fecha de Prèsamo :";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ScrollBar;
            textBox4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(404, 53);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 21);
            textBox4.TabIndex = 7;
            textBox4.Text = "Mièrcoles, 12 de agosto del 2026";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLimpiar);
            groupBox3.Controls.Add(btEliminar);
            groupBox3.Controls.Add(btnActualizar);
            groupBox3.Controls.Add(btnRegistrarPrèstamo);
            groupBox3.Controls.Add(btnNuevo);
            groupBox3.Location = new Point(73, 287);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(623, 46);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
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
            // btnLimpiar
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(73, 339);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(623, 82);
            dataGridView1.TabIndex = 3;
            // 
            // FormREGISTRO_DE_PRÈSTAMOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_210653;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormREGISTRO_DE_PRÈSTAMOS";
            Text = "FormREGISTRO_DE_PRÈSTAMOS";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblEstudiante;
        private Label lblFechaDePrèstamo;
        private TextBox textBox3;
        private Label lblEstadoDelLibro;
        private TextBox textBox2;
        private Label lblLibro;
        private TextBox textBox1;
        private TextBox textBox4;
        private GroupBox groupBox3;
        private Button btnRegistrarPrèstamo;
        private Button btnNuevo;
        private Button btnLimpiar;
        private Button btEliminar;
        private Button btnActualizar;
        private DataGridView dataGridView1;
    }
}