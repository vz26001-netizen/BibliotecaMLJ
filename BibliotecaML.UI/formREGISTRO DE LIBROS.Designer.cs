using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BibliotecaML.UI
{
    public partial class FormREGISTRO_DE_LIBROS : Form
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
            txtEstado = new TextBox();
            lblEstado = new Label();
            txtCategoria = new TextBox();
            lblCategoria = new Label();
            txtEditorial = new TextBox();
            lblEditorial = new Label();
            txtAutor = new TextBox();
            lblAutor = new Label();
            txtTitulo = new TextBox();
            lblTitulo = new Label();
            txtLibro = new TextBox();
            lblIdDelLibro = new Label();
            dgvLibros = new DataGridView();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            groupBox3 = new GroupBox();
            groupBox2.SuspendLayout();
            ((ISupportInitialize)dgvLibros).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_1736211;
            groupBox1.Location = new Point(339, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(184, 170);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEstado);
            groupBox2.Controls.Add(lblEstado);
            groupBox2.Controls.Add(txtCategoria);
            groupBox2.Controls.Add(lblCategoria);
            groupBox2.Controls.Add(txtEditorial);
            groupBox2.Controls.Add(lblEditorial);
            groupBox2.Controls.Add(txtAutor);
            groupBox2.Controls.Add(lblAutor);
            groupBox2.Controls.Add(txtTitulo);
            groupBox2.Controls.Add(lblTitulo);
            groupBox2.Controls.Add(txtLibro);
            groupBox2.Controls.Add(lblIdDelLibro);
            groupBox2.Location = new Point(136, 251);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(656, 157);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // txtEstado
            // 
            txtEstado.BackColor = SystemColors.ScrollBar;
            txtEstado.Location = new Point(419, 109);
            txtEstado.Margin = new Padding(3, 4, 3, 4);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(173, 27);
            txtEstado.TabIndex = 11;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(353, 109);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(65, 18);
            lblEstado.TabIndex = 10;
            lblEstado.Text = "Estado :";
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = SystemColors.ScrollBar;
            txtCategoria.Location = new Point(419, 65);
            txtCategoria.Margin = new Padding(3, 4, 3, 4);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(173, 27);
            txtCategoria.TabIndex = 9;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(335, 65);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(85, 18);
            lblCategoria.TabIndex = 8;
            lblCategoria.Text = "Categoria :";
            // 
            // txtEditorial
            // 
            txtEditorial.BackColor = SystemColors.ScrollBar;
            txtEditorial.Location = new Point(419, 21);
            txtEditorial.Margin = new Padding(3, 4, 3, 4);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(173, 27);
            txtEditorial.TabIndex = 7;
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditorial.Location = new Point(345, 25);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(75, 18);
            lblEditorial.TabIndex = 6;
            lblEditorial.Text = "Editorial :";
            // 
            // txtAutor
            // 
            txtAutor.BackColor = SystemColors.ScrollBar;
            txtAutor.Location = new Point(117, 105);
            txtAutor.Margin = new Padding(3, 4, 3, 4);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(170, 27);
            txtAutor.TabIndex = 5;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.Location = new Point(59, 109);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(54, 18);
            lblAutor.TabIndex = 4;
            lblAutor.Text = "Autor :";
            // 
            // txtTitulo
            // 
            txtTitulo.BackColor = SystemColors.ScrollBar;
            txtTitulo.Location = new Point(117, 61);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(170, 27);
            txtTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(59, 65);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(57, 18);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Tìtulo :";
            // 
            // txtLibro
            // 
            txtLibro.BackColor = SystemColors.ScrollBar;
            txtLibro.Location = new Point(117, 15);
            txtLibro.Margin = new Padding(3, 4, 3, 4);
            txtLibro.Name = "txtLibro";
            txtLibro.Size = new Size(170, 27);
            txtLibro.TabIndex = 1;
            // 
            // lblIdDelLibro
            // 
            lblIdDelLibro.AutoSize = true;
            lblIdDelLibro.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdDelLibro.Location = new Point(31, 25);
            lblIdDelLibro.Name = "lblIdDelLibro";
            lblIdDelLibro.Size = new Size(89, 18);
            lblIdDelLibro.TabIndex = 0;
            lblIdDelLibro.Text = "IDdel libro :";
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(136, 501);
            dgvLibros.Margin = new Padding(3, 4, 3, 4);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.Size = new Size(656, 83);
            dgvLibros.TabIndex = 3;
            dgvLibros.CellContentClick += dgvLibros_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ScrollBar;
            btnAgregar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(24, 19);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar ";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ScrollBar;
            btnActualizar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(179, 19);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(86, 31);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ScrollBar;
            btnEliminar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(337, 19);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ScrollBar;
            btnLimpiar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(493, 19);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
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
            groupBox3.Location = new Point(136, 416);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(656, 57);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // FormREGISTRO_DE_LIBROS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Captura_de_pantalla_2026_08_12_192254;
            ClientSize = new Size(914, 600);
            Controls.Add(dgvLibros);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormREGISTRO_DE_LIBROS";
            Text = "REGISTRO DE LIBROS";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((ISupportInitialize)dgvLibros).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtLibro;
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
        private TextBox txtEstado;
        private DataGridView dgvLibros;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private GroupBox groupBox3;
    }
}