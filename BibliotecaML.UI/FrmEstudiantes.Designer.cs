using System;
using System.Drawing;
using System.Windows.Forms;

namespace BibliotecaML.UI
{
    partial class FrmEstudiantes
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
            Datos = new GroupBox();
            lblDatos = new Label();
            txtIdTelefono = new TextBox();
            lblTelefono = new Label();
            txIdCorreo = new TextBox();
            lblCorreo = new Label();
            txtIdDocumento = new TextBox();
            lblDocumento = new Label();
            txtIdApellido = new TextBox();
            lblApellido = new Label();
            txtIdNombre = new TextBox();
            lblNombre = new Label();
            txtEstudiante = new TextBox();
            lblIDEstudiante = new Label();
            grpBotones = new GroupBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            btnNuevo = new Button();
            dgvEstudiantes = new DataGridView();
            ColIdEstudiante = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colApellido = new DataGridViewTextBoxColumn();
            colDocumento = new DataGridViewTextBoxColumn();
            colCorreo = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            lblGestiondeEstudiantes = new GroupBox();
            label1 = new Label();
            Datos.SuspendLayout();
            grpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            lblGestiondeEstudiantes.SuspendLayout();
            SuspendLayout();
            // 
            // Datos
            // 
            Datos.Controls.Add(lblDatos);
            Datos.Controls.Add(txtIdTelefono);
            Datos.Controls.Add(lblTelefono);
            Datos.Controls.Add(txIdCorreo);
            Datos.Controls.Add(lblCorreo);
            Datos.Controls.Add(txtIdDocumento);
            Datos.Controls.Add(lblDocumento);
            Datos.Controls.Add(txtIdApellido);
            Datos.Controls.Add(lblApellido);
            Datos.Controls.Add(txtIdNombre);
            Datos.Controls.Add(lblNombre);
            Datos.Controls.Add(txtEstudiante);
            Datos.Controls.Add(lblIDEstudiante);
            Datos.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            Datos.Location = new System.Drawing.Point(135, 103);
            Datos.Margin = new Padding(3, 4, 3, 4);
            Datos.Name = "Datos";
            Datos.Padding = new Padding(3, 4, 3, 4);
            Datos.Size = new Size(747, 179);
            Datos.TabIndex = 1;
            Datos.TabStop = false;
            // 
            // lblDatos
            // 
            lblDatos.AutoSize = true;
            lblDatos.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, (byte)0); lblDatos.Location = new Point(7, 0);
            lblDatos.Location = new System.Drawing.Point(7, 0);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(71, 24);
            lblDatos.TabIndex = 12;
            lblDatos.Text = "Datos ";
            // 
            // txtIdTelefono
            // 
            txtIdTelefono.BackColor = SystemColors.InactiveCaption;
            txtIdTelefono.Location = new Point(617, 129);
            txtIdTelefono.Margin = new Padding(3, 4, 3, 4);
            txtIdTelefono.Name = "txtIdTelefono";
            txtIdTelefono.Size = new Size(114, 25);
            txtIdTelefono.TabIndex = 11;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(514, 133);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(79, 18);
            lblTelefono.TabIndex = 10;
            lblTelefono.Text = "Teléfono :";
            // 
            // txIdCorreo
            // 
            txIdCorreo.BackColor = SystemColors.InactiveCaption;
            txIdCorreo.Location = new Point(387, 125);
            txIdCorreo.Margin = new Padding(3, 4, 3, 4);
            txIdCorreo.Name = "txIdCorreo";
            txIdCorreo.Size = new Size(114, 25);
            txIdCorreo.TabIndex = 9;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(274, 125);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(66, 18);
            lblCorreo.TabIndex = 8;
            lblCorreo.Text = "Correo :";
            // 
            // txtIdDocumento
            // 
            txtIdDocumento.BackColor = SystemColors.InactiveCaption;
            txtIdDocumento.Location = new Point(133, 125);
            txtIdDocumento.Margin = new Padding(3, 4, 3, 4);
            txtIdDocumento.Name = "txtIdDocumento";
            txtIdDocumento.Size = new Size(114, 25);
            txtIdDocumento.TabIndex = 7;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Location = new Point(22, 125);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(97, 18);
            lblDocumento.TabIndex = 6;
            lblDocumento.Text = "Documento :";
            // 
            // txtIdApellido
            // 
            txtIdApellido.BackColor = SystemColors.InactiveCaption;
            txtIdApellido.ForeColor = SystemColors.InactiveCaption;
            txtIdApellido.Location = new Point(617, 81);
            txtIdApellido.Margin = new Padding(3, 4, 3, 4);
            txtIdApellido.Name = "txtIdApellido";
            txtIdApellido.Size = new Size(114, 25);
            txtIdApellido.TabIndex = 5;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(518, 85);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(73, 18);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido :";
            // 
            // txtIdNombre
            // 
            txtIdNombre.BackColor = SystemColors.InactiveCaption;
            txtIdNombre.Location = new Point(387, 81);
            txtIdNombre.Margin = new Padding(3, 4, 3, 4);
            txtIdNombre.Name = "txtIdNombre";
            txtIdNombre.Size = new Size(114, 25);
            txtIdNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(267, 85);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(72, 18);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre :";
            // 
            // txtEstudiante
            // 
            txtEstudiante.BackColor = SystemColors.InactiveCaption;
            txtEstudiante.Location = new Point(133, 81);
            txtEstudiante.Margin = new Padding(3, 4, 3, 4);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(114, 25);
            txtEstudiante.TabIndex = 1;
            // 
            // lblIDEstudiante
            // 
            lblIDEstudiante.AutoSize = true;
            lblIDEstudiante.Location = new Point(22, 85);
            lblIDEstudiante.Name = "lblIDEstudiante";
            lblIDEstudiante.Size = new Size(111, 18);
            lblIDEstudiante.TabIndex = 0;
            lblIDEstudiante.Text = "ID Estudiante :";
            // 
            // grpBotones
            // 
            grpBotones.Controls.Add(btnLimpiar);
            grpBotones.Controls.Add(btnEliminar);
            grpBotones.Controls.Add(btnActualizar);
            grpBotones.Controls.Add(btnAgregar);
            grpBotones.Controls.Add(btnNuevo);
            grpBotones.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBotones.Location = new Point(135, 289);
            grpBotones.Margin = new Padding(3, 4, 3, 4);
            grpBotones.Name = "grpBotones";
            grpBotones.Padding = new Padding(3, 4, 3, 4);
            grpBotones.Size = new Size(747, 81);
            grpBotones.TabIndex = 2;
            grpBotones.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ScrollBar;
            btnLimpiar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(630, 19);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(101, 45);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ScrollBar;
            btnEliminar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(485, 19);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 45);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ScrollBar;
            btnActualizar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(337, 19);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(102, 45);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ScrollBar;
            btnAgregar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(181, 19);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(109, 45);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.ScrollBar;
            btnNuevo.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(22, 19);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(111, 45);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Columns.AddRange(new DataGridViewColumn[] { ColIdEstudiante, colNombre, colApellido, colDocumento, colCorreo, colTelefono });
            dgvEstudiantes.Location = new Point(138, 388);
            dgvEstudiantes.Margin = new Padding(3, 4, 3, 4);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.RowHeadersWidth = 51;
            dgvEstudiantes.Size = new Size(744, 119);
            dgvEstudiantes.TabIndex = 3;
            dgvEstudiantes.CellClick += dataGridView1_CellClick;
            dgvEstudiantes.CellContentClick += dgvEstudiantes_CellContentClick;
            // 
            // ColIdEstudiante
            // 
            ColIdEstudiante.HeaderText = "Id Estudiante";
            ColIdEstudiante.MinimumWidth = 6;
            ColIdEstudiante.Name = "ColIdEstudiante";
            ColIdEstudiante.Width = 125;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 6;
            colNombre.Name = "colNombre";
            colNombre.Width = 125;
            // 
            // colApellido
            // 
            colApellido.HeaderText = "Apellido";
            colApellido.MinimumWidth = 6;
            colApellido.Name = "colApellido";
            colApellido.Width = 125;
            // 
            // colDocumento
            // 
            colDocumento.HeaderText = "Documento";
            colDocumento.MinimumWidth = 6;
            colDocumento.Name = "colDocumento";
            colDocumento.Width = 125;
            // 
            // colCorreo
            // 
            colCorreo.HeaderText = "Correo";
            colCorreo.MinimumWidth = 6;
            colCorreo.Name = "colCorreo";
            colCorreo.Width = 125;
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Teléfono";
            colTelefono.MinimumWidth = 6;
            colTelefono.Name = "colTelefono";
            colTelefono.Width = 125;
            // 
            // lblGestiondeEstudiantes
            // 
            lblGestiondeEstudiantes.Controls.Add(label1);
            lblGestiondeEstudiantes.Location = new Point(331, 16);
            lblGestiondeEstudiantes.Margin = new Padding(3, 4, 3, 4);
            lblGestiondeEstudiantes.Name = "lblGestiondeEstudiantes";
            lblGestiondeEstudiantes.Padding = new Padding(3, 4, 3, 4);
            lblGestiondeEstudiantes.Size = new Size(353, 59);
            lblGestiondeEstudiantes.TabIndex = 4;
            lblGestiondeEstudiantes.TabStop = false;
            lblGestiondeEstudiantes.Enter += lblGestiòndeEstudiantes_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(40, 15);
            label1.Name = "label1";
            label1.Size = new Size(274, 29);
            label1.TabIndex = 0;
            label1.Text = "GESTIÓN DE ESTUDIANTES";
            // 
            // FrmEstudiantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._110728;
            ClientSize = new Size(982, 600);
            Controls.Add(lblGestiondeEstudiantes);
            Controls.Add(dgvEstudiantes);
            Controls.Add(grpBotones);
            Controls.Add(Datos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmEstudiantes";
            Text = "REGISTRO DE ESTUDIANTES";
            Datos.ResumeLayout(false);
            Datos.PerformLayout();
            grpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            lblGestiondeEstudiantes.ResumeLayout(false);
            lblGestiondeEstudiantes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Datos;
        private Label lblDatos;
        private Label lblIDEstudiante;
        private TextBox txtEstudiante;
        private Label lblNombre;
        private TextBox txtIdNombre;
        private Label lblApellido;
        private TextBox txtIdApellido;
        private Label lblDocumento;
        private TextBox txtIdDocumento;
        private Label lblCorreo;
        private TextBox txIdCorreo;
        private Label lblTelefono;
        private TextBox txtIdTelefono;
        private GroupBox grpBotones;
        private Button btnNuevo;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvEstudiantes;
        private DataGridViewTextBoxColumn ColIdEstudiante;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colApellido;
        private DataGridViewTextBoxColumn colDocumento;
        private DataGridViewTextBoxColumn colCorreo;
        private DataGridViewTextBoxColumn colTelefono;
        private GroupBox lblGestiondeEstudiantes;
        private Label label1;
    }
}