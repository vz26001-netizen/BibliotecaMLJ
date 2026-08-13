namespace BibliotecaML.UI
{
    partial class formREGISTRO_DE_LIBROS
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
            lblIdDelLibro = new Label();
            txtdellibro = new TextBox();
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblAutor = new Label();
            txtAutor = new TextBox();
            lblEditorial = new Label();
            txtEditorial = new TextBox();
            lblCategoria = new Label();
            txtCategoria = new TextBox();
            lblEstado = new Label();
            txEstado = new TextBox();
            dataGridView1 = new DataGridView();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            groupBox3 = new GroupBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_1736211;
            groupBox1.Location = new Point(303, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(186, 167);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txEstado);
            groupBox2.Controls.Add(lblEstado);
            groupBox2.Controls.Add(txtCategoria);
            groupBox2.Controls.Add(lblCategoria);
            groupBox2.Controls.Add(txtEditorial);
            groupBox2.Controls.Add(lblEditorial);
            groupBox2.Controls.Add(txtAutor);
            groupBox2.Controls.Add(lblAutor);
            groupBox2.Controls.Add(txtTitulo);
            groupBox2.Controls.Add(lblTitulo);
            groupBox2.Controls.Add(txtdellibro);
            groupBox2.Controls.Add(lblIdDelLibro);
            groupBox2.Location = new Point(119, 188);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(574, 118);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // lblIdDelLibro
            // 
            lblIdDelLibro.AutoSize = true;
            lblIdDelLibro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdDelLibro.Location = new Point(27, 19);
            lblIdDelLibro.Name = "lblIdDelLibro";
            lblIdDelLibro.Size = new Size(69, 15);
            lblIdDelLibro.TabIndex = 0;
            lblIdDelLibro.Text = "IDdel libro :";
            // 
            // txtdellibro
            // 
            txtdellibro.BackColor = SystemColors.ScrollBar;
            txtdellibro.Location = new Point(102, 11);
            txtdellibro.Name = "txtdellibro";
            txtdellibro.Size = new Size(149, 23);
            txtdellibro.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(52, 49);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(44, 15);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Tìtulo :";
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = SystemColors.ScrollBar;
            txtTitulo.Location = new Point(102, 46);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(149, 23);
            txtTitulo.TabIndex = 3;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(52, 82);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(44, 15);
            lblAutor.TabIndex = 4;
            lblAutor.Text = "Autor :";
            // 
            // txtAutor
            // 
            txtAutor.BackColor = SystemColors.ScrollBar;
            txtAutor.Location = new Point(102, 79);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(149, 23);
            txtAutor.TabIndex = 5;
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditorial.Location = new Point(302, 19);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(59, 15);
            lblEditorial.TabIndex = 6;
            lblEditorial.Text = "Editorial :";
            // 
            // txtEditorial
            // 
            txtEditorial.BackColor = SystemColors.ScrollBar;
            txtEditorial.Location = new Point(367, 16);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(152, 23);
            txtEditorial.TabIndex = 7;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(293, 49);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(68, 15);
            lblCategoria.TabIndex = 8;
            lblCategoria.Text = "Categoria :";
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = SystemColors.ScrollBar;
            txtCategoria.Location = new Point(367, 49);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(152, 23);
            txtCategoria.TabIndex = 9;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(309, 82);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(52, 15);
            lblEstado.TabIndex = 10;
            lblEstado.Text = "Estado :";
            // 
            // txEstado
            // 
            txEstado.BackColor = SystemColors.ScrollBar;
            txEstado.Location = new Point(367, 82);
            txEstado.Name = "txEstado";
            txEstado.Size = new Size(152, 23);
            txEstado.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(119, 376);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(574, 62);
            dataGridView1.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ScrollBar;
            btnAgregar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(21, 14);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar ";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ScrollBar;
            btnActualizar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(157, 14);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ScrollBar;
            btnEliminar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(295, 14);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ScrollBar;
            btnLimpiar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(431, 14);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnLimpiar);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Controls.Add(btnActualizar);
            groupBox3.Controls.Add(btnAgregar);
            groupBox3.Location = new Point(119, 312);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(574, 43);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // formREGISTRO_DE_LIBROS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_192254;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "formREGISTRO_DE_LIBROS";
            Text = "formREGISTRO_DE_LIBROS";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtdellibro;
        private Label lblIdDelLibro;
        private TextBox txtAutor;
        private Label lblAutor;
        private TextBox txtTitulo;
        private Label lblTitulo;
        private Label lblEstado;
        private TextBox txtCategoria;
        private Label lblCategoria;
        private TextBox txtEditorial;
        private Label lblEditorial;
        private TextBox txEstado;
        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private GroupBox groupBox3;
    }
}